# Struct (struct)

Um `struct` é um **tipo de valor** em C#. Enquanto uma `class` é um molde que cria objetos na memória heap gerenciados por referência, um `struct` carrega os dados diretamente — sem referência, sem Garbage Collector, sem overhead.

A forma mais fácil de entender: use `struct` quando o dado **é** o valor, não quando o dado **aponta para** um valor.

---

## A diferença fundamental: cópia vs. referência

Esse é o comportamento mais importante de entender:

```csharp
// Com CLASS: duas variáveis apontam para o mesmo objeto
public class PontoClasse
{
    public int X { get; set; }
    public int Y { get; set; }
}

var a = new PontoClasse { X = 2, Y = 3 };
var b = a;        // b aponta para o MESMO objeto que a
b.X = 10;

Console.WriteLine(a.X);  // 10 — a também mudou!
Console.WriteLine(b.X);  // 10


// Com STRUCT: cada variável tem sua própria cópia
public struct PontoStruct
{
    public int X { get; set; }
    public int Y { get; set; }
}

var p1 = new PontoStruct { X = 2, Y = 3 };
var p2 = p1;      // p2 recebe uma CÓPIA independente
p2.X = 10;

Console.WriteLine(p1.X);  // 2 — p1 não foi afetado
Console.WriteLine(p2.X);  // 10
```

> Esse comportamento de cópia é exatamente o que torna `struct` seguro para representar valores que nunca devem ser compartilhados acidentalmente.

---

## Exemplos aplicáveis

### Dinheiro / valores monetários

```csharp
public struct Dinheiro
{
    public decimal Valor { get; }
    public string Moeda { get; }

    public Dinheiro(decimal valor, string moeda)
    {
        if (valor < 0) throw new ArgumentException("Valor não pode ser negativo.");
        Valor = valor;
        Moeda = moeda;
    }

    public Dinheiro Somar(Dinheiro outro)
    {
        if (Moeda != outro.Moeda)
            throw new InvalidOperationException("Moedas diferentes.");
        return new Dinheiro(Valor + outro.Valor, Moeda);
    }

    public override string ToString() => $"{Moeda} {Valor:F2}";
}

// Uso:
var preco = new Dinheiro(49.90m, "BRL");
var frete = new Dinheiro(15.00m, "BRL");
var total = preco.Somar(frete);

Console.WriteLine(total);  // BRL 64.90

// Cada atribuição é independente — sem risco de alterar o original
var desconto = preco;
// alterar desconto não afeta preco
```

---

### Intervalo de datas

```csharp
public struct Periodo
{
    public DateTime Inicio { get; }
    public DateTime Fim { get; }
    public int DiasTotal => (Fim - Inicio).Days;

    public Periodo(DateTime inicio, DateTime fim)
    {
        if (fim < inicio) throw new ArgumentException("Fim deve ser após o início.");
        Inicio = inicio;
        Fim = fim;
    }

    public bool Contem(DateTime data) => data >= Inicio && data <= Fim;

    public bool Sobrepos(Periodo outro) => Inicio < outro.Fim && Fim > outro.Inicio;

    public override string ToString() => $"{Inicio:dd/MM/yyyy} até {Fim:dd/MM/yyyy} ({DiasTotal} dias)";
}

// Uso:
var ferias = new Periodo(new DateTime(2024, 7, 1), new DateTime(2024, 7, 15));
var feriado = new Periodo(new DateTime(2024, 7, 9), new DateTime(2024, 7, 9));

Console.WriteLine(ferias);                          // 01/07/2024 até 15/07/2024 (14 dias)
Console.WriteLine(ferias.Contem(new DateTime(2024, 7, 10)));  // True
Console.WriteLine(ferias.Sobrepos(feriado));        // True
```

---

### Coordenadas geográficas

```csharp
public struct Coordenada
{
    public double Latitude { get; }
    public double Longitude { get; }

    public Coordenada(double latitude, double longitude)
    {
        if (latitude < -90 || latitude > 90)
            throw new ArgumentException("Latitude inválida.");
        if (longitude < -180 || longitude > 180)
            throw new ArgumentException("Longitude inválida.");

        Latitude = latitude;
        Longitude = longitude;
    }

    // Distância em km usando fórmula de Haversine
    public double DistanciaAte(Coordenada outra)
    {
        const double R = 6371;
        var dLat = (outra.Latitude - Latitude) * Math.PI / 180;
        var dLon = (outra.Longitude - Longitude) * Math.PI / 180;
        var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(Latitude * Math.PI / 180) * Math.Cos(outra.Latitude * Math.PI / 180) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
        return R * 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
    }

    public override string ToString() => $"({Latitude:F6}, {Longitude:F6})";
}

// Uso:
var saoPaulo    = new Coordenada(-23.5505, -46.6333);
var riodeJaneiro = new Coordenada(-22.9068, -43.1729);

Console.WriteLine($"Distância: {saoPaulo.DistanciaAte(riodeJaneiro):F0} km");  // ~357 km
```

---

### Resultado de operação (sem exceção)

Padrão comum para retornar sucesso/erro sem lançar exceção:

```csharp
public struct Resultado<T>
{
    public bool Sucesso { get; }
    public T Valor { get; }
    public string Erro { get; }

    private Resultado(bool sucesso, T valor, string erro)
    {
        Sucesso = sucesso;
        Valor = valor;
        Erro = erro;
    }

    public static Resultado<T> Ok(T valor) => new Resultado<T>(true, valor, null);
    public static Resultado<T> Falhou(string erro) => new Resultado<T>(false, default, erro);

    public override string ToString() => Sucesso ? $"Ok({Valor})" : $"Erro({Erro})";
}

// Uso:
public static Resultado<int> Dividir(int a, int b)
{
    if (b == 0) return Resultado<int>.Falhou("Divisão por zero.");
    return Resultado<int>.Ok(a / b);
}

var r1 = Dividir(10, 2);
var r2 = Dividir(10, 0);

if (r1.Sucesso) Console.WriteLine(r1.Valor);  // 5
if (!r2.Sucesso) Console.WriteLine(r2.Erro);  // Divisão por zero.
```

---

## Struct imutável (readonly struct)

Em C# moderno, `readonly struct` garante que nenhum campo pode ser alterado após a criação — tornando o comportamento de cópia ainda mais previsível:

```csharp
public readonly struct Temperatura
{
    public double Celsius { get; }
    public double Fahrenheit => Celsius * 9 / 5 + 32;
    public double Kelvin => Celsius + 273.15;

    public Temperatura(double celsius)
    {
        Celsius = celsius;
    }

    public Temperatura Somar(double graus) => new Temperatura(Celsius + graus);

    public override string ToString() => $"{Celsius:F1}°C / {Fahrenheit:F1}°F";
}

// Uso:
var temp = new Temperatura(25);
var maisQuente = temp.Somar(5);

Console.WriteLine(temp);       // 25.0°C / 77.0°F — original inalterado
Console.WriteLine(maisQuente); // 30.0°C / 86.0°F
```

---

## O que struct NÃO pode fazer

```csharp
// ❌ Struct não suporta herança de outras classes ou structs
public struct B : A { }  // erro de compilação

// ❌ Não pode ter construtor sem parâmetros explícito (antes do C# 10)
public struct Ponto
{
    public Ponto() { }  // erro em C# 9 e anteriores

// ✅ A partir do C# 10, construtores sem parâmetros são permitidos
}

// ✅ Struct pode implementar interfaces
public struct Temperatura : IComparable<Temperatura>
{
    public int CompareTo(Temperatura outra) => Celsius.CompareTo(outra.Celsius);
}
```

---

## Quando usar struct vs. class

| Critério | `struct` | `class` |
|---|---|---|
| Tamanho do dado | Pequeno (até ~16 bytes) | Qualquer tamanho |
| Comportamento ao copiar | Cópia independente | Mesma referência |
| Precisa de herança | Não | Sim |
| Ciclo de vida | Stack ou inline | Heap + GC |
| Mutabilidade | Prefira imutável | Mutável ou imutável |
| Exemplos práticos | Dinheiro, Cor, Ponto, Intervalo | Cliente, Pedido, Serviço |

> **Regra prática:** se você se pegar querendo que duas variáveis compartilhem o mesmo dado, use `class`. Se cada variável deve ter sua própria cópia independente, use `struct`.