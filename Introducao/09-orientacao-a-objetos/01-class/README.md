# Classe (class)

Uma `class` é o molde que define um tipo de objeto em C#. Ela agrupa dados e comportamento em um único lugar.

Principais características:
- Define propriedades, campos e métodos.
- Cria instâncias (objetos) com `new`.
- Suporta herança e polimorfismo.
- Normalmente usada para tipos complexos e com estado mutável.

Quando usar:
- Para modelar entidades do mundo real como cliente, produto ou veículo.
- Quando precisa representar algo com comportamento e dados juntos.
- Quando o objeto deve ser passado por referência.

Exemplo:
```csharp
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}

static void Main()
{
    var pessoa = new Pessoa("Maria", 29);
    pessoa.Apresentar();
}
```

Exemplo de quando usar:
- Uma classe `Cliente` que guarda nome, e-mail e método para validar dados.
- Uma classe `ContaBancaria` com depósito, saque e saldo.
- Uma classe `Pedido` que contém itens, valores e comportamento de cálculo.
