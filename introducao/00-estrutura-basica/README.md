# Estrutura básica de um código C#

Neste tópico explicamos como um programa C# é organizado, com namespaces, classes e métodos.

- `namespace`: agrupa classes relacionadas.
- `class`: define um tipo com propriedades e comportamentos.
- `Main`: método principal que inicia a execução do programa.

Quando usar:
- Sempre que estiver criando um novo programa ou um novo arquivo C#.
- Para entender onde colocar seu código e como ele é executado.

Exemplo de uso:
- Um aplicativo console simples para exibir mensagens.
- Um programa de cálculo que recebe valores de entrada e imprime resultados.

Estrutura mínima:
```csharp
using System;

namespace MeuPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo!");
        }
    }
}
```
