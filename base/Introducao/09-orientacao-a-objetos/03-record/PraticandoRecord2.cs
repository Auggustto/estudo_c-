
namespace Introducao.PraticandoRecord2;

/*
    Aula de suport sobre Record em C#.

    - ref types: São tipos de referência, ou seja, quando você cria um objeto de um tipo de referência, 
    ele é alocado na memória heap e a variável que você usa para acessar esse objeto é na verdade uma referência (ou ponteiro) 
    para o local onde o objeto está armazenado.
    
    - value types: São tipos de valor, ou seja, quando você cria uma variável de um tipo de valor, 
    ela é alocada na memória stack e armazena diretamente o valor.

    ** Record faz a copia do valor, ou seja, quando você atribui um record a outro, ele cria uma nova instância com os mesmos valores,
    ao contrário de uma classe, onde a atribuição copia a referência, ou seja, ambos apontam para o mesmo objeto na memória. 

*/



/* 
    APLICABILIDADE
*/

public class Person // Gera um tipo de referência, ou seja, quando você cria um objeto de um tipo de referência, ele é alocado na memória heap e a variável que você usa para acessar esse objeto é na verdade uma referência (ou ponteiro) para o local onde o objeto está armazenado.
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; private set; }
    public int Age { get; set; }

    public void ChangeName(string name)
    => Name = name;
}


public record PersonRecord(string Name, int Age); // Gera um tipo de referência, ou seja, quando você cria um objeto de um tipo de referência, ele é alocado na memória heap e a variável que você usa para acessar esse objeto é na verdade uma referência (ou ponteiro) para o local onde o objeto está armazenado.




