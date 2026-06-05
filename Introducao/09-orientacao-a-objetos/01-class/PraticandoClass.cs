namespace Introducao.PraticandoClass;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Metodo construtor para inicializar os atributos da classe
    // o nome do método precisa ser igual ao nome da classe
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}

public class ContaBancaria
{
    /* 
        Campos vs. Propriedades
        Campo: armazena o dado bruto (convenção: prefixo _ e private)
    */

    private decimal _saldo;

    // Propriedade: expõe o campo com controle de acesso
    public decimal Saldo
    {
        get { return _saldo; }
        private set
        {
            if (value < 0)
            {
                throw new InvalidOperationException("Saldo não pode ser negativo.");
            }
            else
            {
                _saldo += value;
            }
        }
    }

    public void AdicionarSaldo(decimal valor)
    {
        Saldo = valor;
        Console.WriteLine($"Adicionando {valor} ao saldo.");
    }
}

public class Produto
{
    /* 
        Construtores
        O construtor é o método chamado ao criar uma instância com new. 
        Pode haver múltiplos construtores (sobrecarga):
    
    */

    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }

    // 1° Construtor completo
    public Produto(string nome, decimal preco, int estoque)
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }

    // 2°  Construtor com valor padrão para estoque
    public Produto(string nome, decimal preco) : this(nome, preco, 0)
    {
        // ": this(...)" redireciona para o construtor completo
    }

    // 3° Construtor vazio (sem parâmetros)
    public Produto()
    {
        Nome = "Sem nome";
        Preco = 0;
        Estoque = 0;
    }
}