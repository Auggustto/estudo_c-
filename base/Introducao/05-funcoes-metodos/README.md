# Funções / Métodos

Este tópico explica como criar e usar funções e métodos em C#.

- Função/método: bloco de código com nome que pode ser chamado várias vezes.
- Pode receber parâmetros e retornar valores.

Quando usar:
- Para organizar o código em tarefas menores.
- Para evitar repetição de lógica.
- Para separar responsabilidades, como cálculo, exibição e validação.

Exemplo:
```csharp
static int Somar(int x, int y)
{
    return x + y;
}

static void Main(string[] args)
{
    int resultado = Somar(10, 5);
    Console.WriteLine(resultado);
}
```


---

## Analogia com Python

```python
# funcoes.py
def somar(x, y):
    return x + y
```
```python
# main.py
from funcoes import somar
print(somar(10, 20))
```

```csharp
// PraticandoFuncoesMetodos.cs
namespace Introducao.FuncoesMetodos;
public class PraticandoFuncoesMetodos {
    public static int Somar(int x, int y) => x + y;
}
```
```csharp
// Program.cs
using Introducao.FuncoesMetodos;
Console.WriteLine(PraticandoFuncoesMetodos.Somar(10, 20));
```

---

## Regra de ouro

| Python | C# |
|---|---|
| Funções vivem soltas no módulo | Funções **sempre** vivem dentro de uma classe |
| `main` é opcional / `if __name__` | `Main` fica só no `Program.cs` (ou é gerado automaticamente) |
| Um `import` por arquivo | Um `using` cobre todas as classes do namespace |

---

Uso típico:
- Calcular valores dentro de funções específicas.
- Criar métodos que exibem mensagens ou processam dados.
- Reutilizar lógica em diferentes partes do programa.