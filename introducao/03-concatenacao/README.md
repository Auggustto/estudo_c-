# Concatenação (operador + e interpolação de strings)

Este tópico ensina como combinar texto e valores em uma mesma saída.

- Operador `+`: junta duas strings ou string com valores convertidos para texto.
- Interpolação `$"...{valor}..."`: inclui valores diretamente dentro de uma string.

Quando usar:
- `+`: em mensagens simples ou quando preferir concatenar pedaços de texto.
- Interpolação: quando quiser uma forma mais legível e fácil de manter.

Exemplos:
```csharp
string nome = "João";
int idade = 28;

Console.WriteLine("Nome: " + nome + ", idade: " + idade);
Console.WriteLine($"Nome: {nome}, idade: {idade}");
```

Uso típico:
- Exibir informações combinadas em uma mesma linha.
- Construir mensagens para o usuário sem complicar o código.
