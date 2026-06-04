# Arrays / Foreach

Este tópico trata de coleções de dados e como percorrê-las.

- `array`: estrutura que armazena vários valores do mesmo tipo em uma sequência.
- `foreach`: laço que percorre cada elemento de uma coleção de forma simples.

Quando usar:
- `array`: quando precisar guardar vários valores do mesmo tipo em uma ordem fixa.
- `foreach`: quando quiser acessar cada elemento sem controlar índices manualmente.

Exemplo:
```csharp
int[] numeros = { 1, 2, 3, 4, 5 };

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

string[] nomes = { "Ana", "Bruno", "Carlos" };
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}
```

Uso típico:
- Armazenar listas pequenas de itens.
- Processar coleções de dados em ordem.
- Exibir ou calcular valores em massa.
