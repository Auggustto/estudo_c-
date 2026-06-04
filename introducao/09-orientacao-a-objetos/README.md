# Orientação a Objetos

Este tópico apresenta os conceitos básicos de orientação a objetos em C#.

Conceitos principais:
- `classe`: define um tipo com atributos e métodos.
- `objeto`: instância de uma classe.
- `atributos`: dados que descrevem o objeto.
- `métodos`: ações que o objeto pode executar.
- `modificadores de acesso`: `public`, `private`, `protected`, `internal` controlam visibilidade.

Quando usar:
- Para modelar entidades reais como cliente, produto, conta bancária.
- Para organizar código em estruturas reutilizáveis e fáceis de manter.
- Quando o projeto crescer e precisar de encapsulamento e separação de responsabilidades.

Exemplo:
```csharp
class Pessoa
{
    public string Nome { get; set; }
    private int idade;

    public void DefinirIdade(int valor)
    {
        idade = valor;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {idade}");
    }
}

static void Main(string[] args)
{
    Pessoa p = new Pessoa();
    p.Nome = "Lucas";
    p.DefinirIdade(30);
    p.Apresentar();
}
```
