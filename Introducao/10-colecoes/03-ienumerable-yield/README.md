# IEnumerable / yield

`IEnumerable<T>` representa uma sequência que pode ser percorrida. O uso de `yield return` permite criar iteradores de forma simples e eficiente.

Principais características:
- Suporta iteração com `foreach`.
- Pode usar execução diferida (lazy evaluation).
- Permite criar coleções geradas sob demanda.

Quando usar:
- Para retornar uma sequência sem materializar todos os itens na memória.
- Para criar uma lista de valores calculados passo a passo.
- Para expor uma coleção que será percorrida apenas quando necessária.

Exemplo com `yield return`:
```csharp
static IEnumerable<int> GerarPares(int quantidade)
{
    for (int i = 0; i < quantidade; i++)
    {
        yield return i * 2;
    }
}

static void Main()
{
    foreach (int par in GerarPares(5))
    {
        Console.WriteLine(par);
    }
}
```

Diferente de uma lista comum:
- `List<T>` cria todos os elementos imediatamente.
- `IEnumerable<T>` pode gerar cada item apenas quando necessário.

Uso típico:
- Processar linhas de um arquivo uma a uma.
- Construir sequências matemáticas sem armazenar todos os resultados.
- Expor dados de forma compatível com LINQ.
