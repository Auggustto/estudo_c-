
namespace Introducao.PraticandoRecord;

// Record é um tipo de referência imutável, ideal para representar dados que não devem ser alterados após a criação.
// Ele é útil para criar objetos de valor, onde a igualdade é baseada no conteúdo dos dados, e não na referência do objeto.
// Record é uma forma concisa de definir classes imutáveis, com suporte a comparação de igualdade baseada em valor e recursos de desestruturação.

public record Pessoa(string Nome, int Idade);

public static class PraticandoRecord
{
    public static void PessoaRecord()
    {
        var pessoa1 = new Pessoa("Leonardo", 28);
        var pessoa2 = new Pessoa("Leonardo", 28);
        var pessoa3 = pessoa1 with { Idade = 29 }; // Criando um novo objeto com base em pessoa1, mas com a idade modificada

        Console.WriteLine(pessoa1 == pessoa2); // True, pois os valores são iguais
        Console.WriteLine(pessoa3); // Pessoa { Nome = Leonardo, Idade = 29 }
    }
}
