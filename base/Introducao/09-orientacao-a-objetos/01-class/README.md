# Classe (class)

Uma `class` é o molde (blueprint) que define um tipo de objeto em C#. Ela agrupa **dados** (campos e propriedades) e **comportamento** (métodos) em um único lugar, sendo a estrutura fundamental da programação orientada a objetos.

---

## Anatomia de uma classe

```csharp
// Modificador de acesso + palavra-chave + nome da classe
public class Pessoa
{
    // 1. Campos (armazenam dados diretamente)
    private string _documento;

    // 2. Propriedades (controlam acesso aos dados)
    public string Nome { get; set; }
    public int Idade { get; private set; }   // só pode ser alterada internamente

    // 3. Construtor (inicializa o objeto)
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // 4. Métodos (definem comportamento)
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }

    // 5. Método que retorna valor
    public bool EhMaiorDeIdade()
    {
        return Idade >= 18;
    }
}

## Pré-requisitos
- Ter o .NET SDK instalado: https://dotnet.microsoft.com

## Como compilar e executar
1. Crie um projeto de console: `dotnet new console -o MinhaApp`
2. Copie o código do exemplo para `Program.cs` dentro da pasta `MinhaApp`.
3. Execute: `dotnet run` dentro de `MinhaApp`.

## Exercícios
- Crie uma classe `Aluno` com `Nome`, `Matricula` e método `MostrarDados()` e teste no `Main`.
- Implemente uma classe `ContaBancaria` com `Depositar` e `Sacar` e simule operações.

## Dicas para iniciantes
- Comece pequeno: implemente uma classe com poucos membros e teste frequentemente.
- Use `Console.WriteLine` para depurar valores enquanto aprende.
```

---

## Campos vs. Propriedades

Campos e propriedades parecem iguais na superfície, mas têm papéis diferentes:

```csharp
public class ContaBancaria
{
    // Campo: armazena o dado bruto (convenção: prefixo _ e private)
    private decimal _saldo;

    // Propriedade: expõe o campo com controle de acesso
    public decimal Saldo
    {
        get { return _saldo; }
        private set
        {
            if (value < 0)
                throw new InvalidOperationException("Saldo não pode ser negativo.");
            _saldo = value;
        }
    }

    // Propriedade automática: C# gera o campo internamente
    public string Titular { get; set; }

    // Propriedade somente leitura
    public string Agencia { get; } = "0001";
}
```

> Prefira sempre **propriedades** para expor dados. Campos públicos não permitem adicionar lógica depois sem quebrar o código que os usa.

---

## Construtores

O construtor é o método chamado ao criar uma instância com `new`. Pode haver múltiplos construtores (sobrecarga):

```csharp
public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }

    // Construtor completo
    public Produto(string nome, decimal preco, int estoque)
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }

    // Construtor com valor padrão para estoque
    public Produto(string nome, decimal preco) : this(nome, preco, 0)
    {
        // ": this(...)" redireciona para o construtor completo
    }

    // Construtor vazio (sem parâmetros)
    public Produto()
    {
        Nome = "Sem nome";
        Preco = 0;
        Estoque = 0;
    }
}

// Uso:
var p1 = new Produto("Teclado", 250.00m, 10);
var p2 = new Produto("Mouse", 89.90m);    // estoque = 0
var p3 = new Produto();                   // tudo padrão
```

---

## Modificadores de acesso

Controlam quem pode acessar cada membro da classe:

| Modificador | Acesso permitido |
|---|---|
| `public` | Qualquer código |
| `private` | Só dentro da própria classe |
| `protected` | A classe e suas subclasses |
| `internal` | Só dentro do mesmo projeto (assembly) |
| `private protected` | A classe e subclasses dentro do mesmo projeto |

```csharp
public class Funcionario
{
    public string Nome { get; set; }          // visível por todos
    private decimal _salario;                 // só esta classe acessa
    protected string Departamento { get; set; } // subclasses também acessam
    internal string CodigoInterno { get; set; } // visível no projeto
}
```

---

## Métodos estáticos vs. de instância

```csharp
public class Calculadora
{
    // Método de instância: precisa criar objeto antes de chamar
    public int Somar(int a, int b)
    {
        return a + b;
    }

    // Método estático: pertence à classe, não ao objeto
    public static double CalcularJuros(decimal valor, double taxa)
    {
        return (double)valor * taxa;
    }
}

// Uso:
var calc = new Calculadora();
int resultado = calc.Somar(5, 3);            // instância necessária

double juros = Calculadora.CalcularJuros(1000, 0.05);  // sem instância
```

---

## Herança

Uma classe pode herdar membros de outra, estendendo ou modificando comportamento:

```csharp
public class Animal
{
    public string Nome { get; set; }

    public Animal(string nome)
    {
        Nome = nome;
    }

    // "virtual" permite que subclasses sobrescrevam
    public virtual void EmitirSom()
    {
        Console.WriteLine("...");
    }
}

public class Cachorro : Animal  // herda de Animal
{
    public string Raca { get; set; }

    public Cachorro(string nome, string raca) : base(nome)  // chama construtor da base
    {
        Raca = raca;
    }

    // "override" sobrescreve o método da classe pai
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} diz: Au au!");
    }
}

// Uso:
var dog = new Cachorro("Rex", "Labrador");
dog.EmitirSom();   // "Rex diz: Au au!"
```

---

## Classes abstratas e sealed

```csharp
// Classe abstrata: não pode ser instanciada diretamente
// Serve como base obrigatória para outras classes
public abstract class Forma
{
    public abstract double CalcularArea();  // método abstrato: sem corpo, obriga implementação

    public void Exibir()  // método concreto: pode ter implementação
    {
        Console.WriteLine($"Área: {CalcularArea():F2}");
    }
}

public class Circulo : Forma
{
    public double Raio { get; set; }

    public Circulo(double raio) => Raio = raio;

    public override double CalcularArea() => Math.PI * Raio * Raio;
}

// Classe sealed: não pode ser herdada
public sealed class Configuracao
{
    public string ChaveApi { get; set; }
}
```

---

## Inicializadores de objeto

Forma alternativa de inicializar propriedades sem precisar de um construtor específico:

```csharp
public class Endereco
{
    public string Rua { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Cep { get; set; }
}

// Usando inicializador (chaves após o new)
var endereco = new Endereco
{
    Rua = "Av. Paulista, 1000",
    Cidade = "São Paulo",
    Estado = "SP",
    Cep = "01310-100"
};
```

> Útil quando a classe tem muitas propriedades opcionais e criar construtores para cada combinação seria impraticável.

---

## Principais características

- Tipo por **referência**: variáveis armazenam o endereço do objeto na memória, não o objeto em si.
- Suporta **herança simples**: uma classe herda de apenas uma outra.
- Pode implementar **múltiplas interfaces**.
- Instâncias são gerenciadas pelo **Garbage Collector**.
- Membros podem ser `static` (pertencem à classe) ou de instância (pertencem ao objeto).

---

## Quando usar

- Para modelar entidades com **estado mutável** (Cliente, Pedido, ContaBancaria).
- Quando o objeto precisa ser **passado por referência** entre métodos.
- Quando há necessidade de **herança** ou **polimorfismo**.
- Para representar algo com **comportamento complexo** além de apenas guardar dados.
- Quando o ciclo de vida do objeto é gerenciado pelo **Garbage Collector**.

> Se o objeto é pequeno, imutável e representa apenas um conjunto de valores, considere `struct` ou `record` em vez de `class`.

---

## Exemplos de uso real

```csharp
// Entidade de domínio
public class Cliente
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Nome { get; set; }
    public string Email { get; set; }
    private List<Pedido> _pedidos = new();

    public IReadOnlyList<Pedido> Pedidos => _pedidos.AsReadOnly();

    public void AdicionarPedido(Pedido pedido)
    {
        if (pedido == null) throw new ArgumentNullException(nameof(pedido));
        _pedidos.Add(pedido);
    }

    public bool EmailValido() => Email.Contains("@") && Email.Contains(".");
}

// Serviço com lógica de negócio
public class ContaBancaria
{
    public string Numero { get; }
    public string Titular { get; }
    public decimal Saldo { get; private set; }

    public ContaBancaria(string numero, string titular, decimal saldoInicial = 0)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0) throw new ArgumentException("Valor deve ser positivo.");
        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor > Saldo) throw new InvalidOperationException("Saldo insuficiente.");
        Saldo -= valor;
    }

    public void Transferir(decimal valor, ContaBancaria destino)
    {
        Sacar(valor);
        destino.Depositar(valor);
    }
}
```