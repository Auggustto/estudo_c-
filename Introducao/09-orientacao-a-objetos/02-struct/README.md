# Struct (struct)

`struct` é um tipo de valor em C# usado para dados pequenos e simples. Ele é armazenado diretamente na pilha ou dentro de objetos maiores.

Principais características:
- Tipo de valor, cópia o conteúdo ao ser atribuído.
- Usa menos memória para dados pequenos.
- Não suporta herança de classes.
- Ideal para dados imutáveis e leves.

Quando usar:
- Para representar coordenadas, cores, tamanhos ou intervalos.
- Quando o objeto tem poucos campos e baixa complexidade.
- Quando não precisa de herança ou comportamento complexo.

Exemplo:
```csharp
struct Ponto
{
    public int X { get; set; }
    public int Y { get; set; }

    public Ponto(int x, int y)
    {
        X = x;
        Y = y;
    }
}

static void Main()
{
    Ponto p1 = new Ponto(2, 3);
    Ponto p2 = p1;
    p2.X = 10;

    Console.WriteLine($"p1: {p1.X}, {p1.Y}");
    Console.WriteLine($"p2: {p2.X}, {p2.Y}");
}
```

Uso típico:
- `Point`, `Rectangle`, `Color`, `Vector2`.
- Dados que são copiados com segurança e não precisam ser compartilhados por referência.
