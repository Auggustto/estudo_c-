# Laços de repetição (for, do while, while)

Este tópico explica como repetir ações várias vezes.

- `for`: executa um bloco com início, condição e incremento claros.
- `while`: repete enquanto a condição for verdadeira.
- `do while`: repete pelo menos uma vez e verifica a condição no final.

Quando usar:
- `for`: quando souber quantas repetições são necessárias.
- `while`: quando a repetição depender de uma condição que pode mudar durante a execução.
- `do while`: quando quiser executar o bloco ao menos uma vez.

Exemplos:
```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

int j = 0;
while (j < 3)
{
    Console.WriteLine(j);
    j++;
}

int k = 0;
do
{
    Console.WriteLine(k);
    k++;
} while (k < 2);
```
