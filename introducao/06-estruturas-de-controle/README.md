# Estruturas de controle (if, else, else if, switch)

Este tópico mostra como o programa escolhe entre diferentes caminhos de execução.

- `if`: executa um bloco quando a condição for verdadeira.
- `else`: executa quando a condição anterior for falsa.
- `else if`: adiciona outra condição.
- `switch`: escolhe entre várias opções com base em um valor.

Quando usar:
- `if/else`: para decisões simples e checagens de condição.
- `switch`: quando houver muitas opções específicas para comparar.

Exemplo:
```csharp
int nota = 7;

if (nota >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (nota >= 5)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}

char opcao = 'B';
switch (opcao)
{
    case 'A':
        Console.WriteLine("Escolha A");
        break;
    case 'B':
        Console.WriteLine("Escolha B");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}
```
