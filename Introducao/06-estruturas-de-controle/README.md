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

## Analogia com Python

```python
# Python
class PraticandoEstruturasDeControles:
    @staticmethod
    def estrutura_if(numero):
        if numero > 0:
            print("positivo")

# Chamada correta:
PraticandoEstruturasDeControles.estrutura_if(10)

# ❌ Errado (não faz sentido):
obj = PraticandoEstruturasDeControles.estrutura_if(10)  # retorna None
```

Exatamente o mesmo problema — `new` em C# é equivalente a instanciar uma classe, não chamar um método.

---

## Quando usar `new` vs chamada direta

| Situação | Sintaxe |
|---|---|
| Método `static` | `Classe.Metodo(args)` |
| Método de instância | `var obj = new Classe(); obj.Metodo(args)` |
| `void` — não retorna nada | Não atribua a variável nenhuma |
| Retorna valor | `var resultado = Classe.Metodo(args)` |

Como `EstruturaIf` é `static` e `void`, só chama direto e pronto.