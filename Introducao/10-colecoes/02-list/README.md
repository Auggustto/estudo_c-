# List

`List<T>` é uma coleção genérica de tamanho dinâmico que pode crescer e encolher durante a execução.

Principais características:
- Permite adicionar e remover itens.
- Mantém a ordem de inserção.
- Usa índice como `array`, mas com capacidade dinâmica.

Quando usar:
- Quando precisar de uma coleção que muda de tamanho.
- Para listas de itens que serão adicionados ou removidos.
- Quando quiser percorrer os elementos com `foreach`.

Exemplo:
```csharp
var frutas = new List<string>();
frutas.Add("Maçã");
frutas.Add("Banana");
frutas.Add("Laranja");

frutas.Remove("Banana");

Console.WriteLine(frutas.Count); // 2

foreach (var fruta in frutas)
{
    Console.WriteLine(fruta);
}
```

Uso típico:
- Listas de tarefas, itens de carrinho ou resultados de busca.
- Quando você quer adicionar e remover elementos frequentemente.
- Para converter dados de arrays em estrutura flexível.

## Pré-requisitos
- Ter o .NET SDK instalado: https://dotnet.microsoft.com

## Como compilar e executar
1. `dotnet new console -o MinhaApp`
2. Copie o exemplo para `Program.cs` e execute `dotnet run`.

## Exercícios
- Crie uma `List<int>` com números de 1 a 10, remova os pares e mostre os ímpares.
- Ordene uma `List<string>` de nomes e imprima-os em ordem alfabética.

## Dicas para iniciantes
- Use `Add`, `Remove`, `Count` e `Clear` para gerenciar a lista.
- `List<T>` é mais flexível que `array`, porém tem overhead extra quando usada em grande escala.
