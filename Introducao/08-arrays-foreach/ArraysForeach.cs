

namespace Introducao.ArraysForeach;


public class ArraysForeach
{
    public static string EstruturaForeach(List<string> nomes)
    {
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        for (int i = 0; i < nomes.Count; i++)
        {
            Console.WriteLine(nomes[i]);
        }
        return "Foreach executado com sucesso";
    }
}


