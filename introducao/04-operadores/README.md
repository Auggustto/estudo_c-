# Operadores (Aritméticos, Comparação e Lógicos)

Este tópico apresenta os operadores que permitem calcular valores, comparar dados e tomar decisões.

Operadores aritméticos:
- `+`, `-`, `*`, `/`, `%`
- Use para somar, subtrair, multiplicar, dividir e obter resto.

Operadores de comparação:
- `==`, `!=`, `>`, `<`, `>=`, `<=`
- Use para comparar valores e obter `true` ou `false`.

Operadores lógicos:
- `&&` (E), `||` (OU), `!` (NÃO)
- Use para combinar condições booleanas.

Exemplos:
```csharp
int a = 10;
int b = 5;

int soma = a + b;
bool igual = a == b;
bool maior = a > b;
bool condicao = (a > 0) && (b > 0);

Console.WriteLine(soma);
Console.WriteLine(igual);
Console.WriteLine(condicao);
```

Quando usar:
- Aritméticos: sempre que precisar de operações matemáticas.
- Comparação: ao verificar se valores são iguais ou têm relação.
- Lógicos: ao combinar várias condições para controle de fluxo.
