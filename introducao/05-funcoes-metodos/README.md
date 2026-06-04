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

Uso típico:
- Calcular valores dentro de funções específicas.
- Criar métodos que exibem mensagens ou processam dados.
- Reutilizar lógica em diferentes partes do programa.
