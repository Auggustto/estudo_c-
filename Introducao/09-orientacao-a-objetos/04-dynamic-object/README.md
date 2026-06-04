# Dynamic / Object

Este tópico explora `dynamic` e objetos genéricos no C#. Eles permitem trabalhar com tipos que só são definidos em tempo de execução.

Principais características:
- `dynamic`: o compilador desativa a verificação estática de tipo.
- `object`: tipo base de todos os outros tipos em C#.
- `ExpandoObject` permite criar objetos com membros dinâmicos.

Quando usar:
- Para interagir com bibliotecas que retornam tipos desconhecidos em tempo de compilação.
- Para trabalhar com JSON dinâmico ou APIs flexíveis.
- Cuidado: perde segurança de tipo e autocompletar.

Exemplo com `dynamic`:
```csharp
using System;
using System.Dynamic;

static void Main()
{
    dynamic dados = new ExpandoObject();
    dados.Nome = "Paula";
    dados.Idade = 22;
    dados.Saudacao = new Func<string>(() => $"Oi, {dados.Nome}!");

    Console.WriteLine(dados.Nome);
    Console.WriteLine(dados.Idade);
    Console.WriteLine(dados.Saudacao());
}
```

Exemplo com `object`:
```csharp
object valor = 100;

if (valor is int numero)
{
    Console.WriteLine(numero + 50);
}
```

Uso típico:
- Interoperabilidade com COM, Python ou JavaScript.
- Processar dados sem esquema fixo.
- Quando não é possível definir os tipos antes da execução.
