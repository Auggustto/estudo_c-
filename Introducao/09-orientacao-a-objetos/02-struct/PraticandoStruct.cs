
namespace Introducao.PraticandoStruct;

// Com CLASS: duas variáveis apontam para o mesmo objeto
public class PontoClasse
{
    public int X { get; set; }
    public int Y { get; set; }
}


// Com STRUCT: cada variável tem sua própria cópia
public struct PontoStruct
{
    public int X { get; set; }
    public int Y { get; set; }
}