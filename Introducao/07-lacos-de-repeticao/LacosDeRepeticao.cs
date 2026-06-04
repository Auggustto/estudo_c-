
namespace Introducao.LacosDeRepeticao;


public class PraticandoLacosDeRepeticao
{

    public static string EstruturaFor(List<string> nomes)
    {
        for (int i = 0; i < nomes.Count; i++)
        {
            Console.WriteLine($"Índice: {i} - Nome: {nomes[i]}");
        }
        return "Laço For executado com sucesso!";
    }

    public static string EstruturaWhile(List<string> nomes)
    {
        int i = 0;

        while (i < nomes.Count)
        {
            Console.WriteLine($"Índice: {i} - Nome: {nomes[i]}");
            i++;
        }
        return "Laço While executado com sucesso!";
    }

    public static string EstruturaDoWhile(List<string> nomes)
    {
        int i = 0;

        do
        {
            Console.WriteLine($"Índice: {i} - Nome: {nomes[i]}");
            i++;
        } while (i < nomes.Count);
        return "Laço Do While executado com sucesso!";
    }


}