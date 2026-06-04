# IQueryable

`IQueryable<T>` representa uma consulta que pode ser traduzida por um provedor, como bancos de dados ou serviços remotos.

Principais características:
- Trabalha com expressão de árvore em vez de execução imediata.
- Permite que o provedor converta a consulta em outro formato (por exemplo, SQL).
- Mantém o tipo forte enquanto construí a consulta.

Quando usar:
- Ao trabalhar com Entity Framework, LINQ to SQL ou outros provedores de dados.
- Quando quiser filtrar e projetar dados antes de executar a consulta.
- Para consultas que serão traduzidas e otimizadas pelo provedor.

Exemplo:
```csharp
using System;
using System.Linq;

static void Main()
{
    var numeros = new List<int> { 1, 2, 3, 4, 5 }.AsQueryable();

    IQueryable<int> consulta = numeros
        .Where(n => n % 2 == 0)
        .Select(n => n * 10);

    foreach (int valor in consulta)
    {
        Console.WriteLine(valor);
    }
}
```

Observação:
- `IQueryable<T>` e `IEnumerable<T>` podem parecer similares, mas `IQueryable` é usado para consulta remota e tradução.
- `AsQueryable()` transforma uma coleção em uma fonte consultável apenas para demonstração; em um provedor real como EF, a consulta é convertida em SQL.

Uso típico:
- Aplicações que acessam bancos de dados com LINQ.
- Consultas que precisam ser executadas apenas no momento certo.
- Cenários em que a fonte de dados pode fazer otimizações internas.
