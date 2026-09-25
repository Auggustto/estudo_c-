# Generic Type (tipo genérico)

Generics permitem criar classes, métodos e interfaces que funcionam com qualquer tipo, mantendo a segurança de tipo.

Principais características:
- Usam parâmetros de tipo como `T`.
- Evitam código duplicado para diferentes tipos.
- Mantêm verificações de tipo em tempo de compilação.

Quando usar:
- Para coleções e utilitários reutilizáveis.
- Para criar estruturas de dados independentes do tipo exato.
- Para métodos que processam diferentes tipos com a mesma lógica.

Exemplo de classe genérica:
```csharp
class Caixa<T>
{
    public T Conteudo { get; set; }

    public void Mostrar()
    {
        Console.WriteLine($"Conteúdo: {Conteudo}");
    }
}

static void Main()
{
    var caixaInt = new Caixa<int> { Conteudo = 42 };
    cajaInt.Mostrar();

    var caixaTexto = new Caixa<string> { Conteudo = "Olá" };
    caixaTexto.Mostrar();
}
```

Exemplo de método genérico:
```csharp
static void Imprimir<T>(T valor)
{
    Console.WriteLine(valor);
}

Imprimir(10);
Imprimir("Teste");
```

Uso típico:
- `List<T>`, `Dictionary<TKey, TValue>` e outras coleções.
- Repositórios genéricos e serviços que não dependem do tipo exato.

## Pré-requisitos
- Ter o .NET SDK instalado: https://dotnet.microsoft.com

## Como compilar e executar
1. `dotnet new console -o MinhaApp`
2. Copie o exemplo para `Program.cs` e rode `dotnet run`.

## Exercícios
- Implemente uma classe genérica `Caixa<T>` que armazena um valor e tem método `Mostrar()`.
- Crie um método genérico `Trocar<T>(ref T a, ref T b)` que troca dois valores.

## Dicas para iniciantes
- Generics evitam conversões e tornam o código mais seguro em tempo de compilação.
- Pense em generics quando criar coleções ou utilitários que devem funcionar com vários tipos.
