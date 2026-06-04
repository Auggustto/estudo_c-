# Exibindo dados (Console.Write / Console.WriteLine)

Este tópico mostra como enviar texto para o console usando `Console.Write` e `Console.WriteLine`.

- `Console.Write(...)`: escreve conteúdo sem pular linha.
- `Console.WriteLine(...)`: escreve conteúdo e pula para a próxima linha.

Quando usar:
- `Console.WriteLine`: na maioria dos casos quando quiser uma saída legível, linha a linha.
- `Console.Write`: quando precisar continuar escrevendo na mesma linha ou montar uma saída formatada.

Exemplos:
```csharp
Console.Write("Nome: ");
Console.WriteLine("Maria");
Console.WriteLine("Idade: " + 30);
```

Uso típico:
- Mostrar mensagens de boas-vindas.
- Exibir resultados de cálculo.
- Criar interações simples em programas de console.
