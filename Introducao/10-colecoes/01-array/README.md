# Array

Um `array` é uma coleção de elementos do mesmo tipo com tamanho fixo.

Principais características:
- Tamanho definido na criação.
- Acesso por índice com `[]`.
- Guarda elementos sequenciais em memória.

Quando usar:
- Quando souber a quantidade de elementos com antecedência.
- Para listas pequenas que não precisam ser redimensionadas.
- Quando quiser um acesso rápido por índice.

Exemplo:
```csharp
int[] numeros = { 5, 10, 15, 20 };
string[] nomes = new string[3];
nomes[0] = "Ana";
nomes[1] = "Bruno";
nomes[2] = "Carla";

Console.WriteLine(numeros[2]); // 15
Console.WriteLine(nomes[1]);   // Bruno

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
```

Uso típico:
- Vetores de dados matemáticos.
- Armazenar valores de configuração em sequência.
- Quando o tamanho não muda após a criação.

## Pré-requisitos
- Ter o .NET SDK instalado: https://dotnet.microsoft.com

## Como compilar e executar
1. `dotnet new console -o MinhaApp`
2. Copie o exemplo para `Program.cs` e execute `dotnet run`.

## Exercícios
- Crie um array de inteiros e calcule a soma de todos os elementos.
- Crie um array de strings com nomes e imprima o último elemento.

## Dicas para iniciantes
- Use `Length` para obter o tamanho do array.
- Se precisar adicionar/remove itens dinamicamente, prefira `List<T>`.
