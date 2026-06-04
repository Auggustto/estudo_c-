# Record (record)

`record` é um tipo de referência criado para representar dados imutáveis ou que possuem igualdade por valor.

Principais características:
- Tem igualdade baseada no conteúdo.
- Suporta propriedades `init` para imutabilidade após a construção.
- Permite o uso do operador `with` para criar cópias com alterações.
- Excelente para modelos de dados e DTOs.

Quando usar:
- Para representar dados que não devem mudar depois de criados.
- Para classes que precisam ser comparadas pelo conteúdo.
- Para transferir dados entre camadas da aplicação.

Exemplo:
```csharp
record Pessoa(string Nome, int Idade);

static void Main()
{
    var pessoa1 = new Pessoa("João", 30);
    var pessoa2 = new Pessoa("João", 30);
    var pessoa3 = pessoa1 with { Idade = 31 };

    Console.WriteLine(pessoa1 == pessoa2); // true
    Console.WriteLine(pessoa3); // Pessoa { Nome = João, Idade = 31 }
}
```

Diferente de `class`:
- `class` compara por referência, a menos que `Equals` seja sobrescrito.
- `record` compara por valor automaticamente.

Uso típico:
- Dados de configuração.
- Resultados retornados de APIs.
- Objetos usados em lógica funcional e `pattern matching`.
