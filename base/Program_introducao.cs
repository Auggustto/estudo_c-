
using Introducao.FuncoesMetodos;
using Introducao.EstruturasDeControles;
using Introducao.LacosDeRepeticao;
using Introducao.ArraysForeach;
using Introducao.PraticandoClass;
using Introducao.PraticandoStruct;
using Introducao.PraticandoRecord;
using Introducao.PraticandoRecord2;

// Funções e métodos são blocos de código que realizam uma tarefa específica. 
// Eles podem receber parâmetros, executar uma série de instruções e retornar um valor. 
// A principal diferença entre funções e métodos é que os métodos estão associados a objetos, enquanto as funções são independentes.

/*
int resultadoSoma = PraticandoFuncoesMetodos.Somar(10, 20);
Console.WriteLine(resultadoSoma);

int resultadoSubtracao = PraticandoFuncoesMetodos.Subtrair(10, 20);
Console.WriteLine(resultadoSubtracao);

int resultadoMultiplicacao = PraticandoFuncoesMetodos.Multiplicar(10, 20);
Console.WriteLine(resultadoMultiplicacao);
Console.WriteLine(new string('-', 30));

*/


// Estruturas de controle são blocos de código que controlam o fluxo de execução do programa. 
// Elas permitem que você execute diferentes blocos de código com base em condições específicas ou repita um bloco de código várias vezes.
/*
PraticandoEstruturasDeControles.EstruturaIf(10);
PraticandoEstruturasDeControles.EstruturaSwitch("Domingo");
Console.WriteLine(new string('-', 30));
*/

// Laços de repetição são usados para executar um bloco de código várias vezes, enquanto uma condição for verdadeira.
/*
var nomes = new List<string> { "Alice", "Bob", "Charlie" };

Console.WriteLine(PraticandoLacosDeRepeticao.EstruturaFor(nomes));
Console.WriteLine(PraticandoLacosDeRepeticao.EstruturaWhile(nomes));
Console.WriteLine(PraticandoLacosDeRepeticao.EstruturaDoWhile(nomes));
Console.WriteLine(new string('-', 30));
*/

// O foreach é uma estrutura de controle que permite iterar sobre os elementos de uma coleção, como arrays ou listas, de forma mais simples e legível. 
// Ele é especialmente útil quando você não precisa acessar os índices dos elementos, mas apenas os valores.
/*
Console.WriteLine(ArraysForeach.EstruturaForeach(nomes));
*/

// Orientação a objetos é um paradigma de programação que organiza o código em torno de objetos, que são instâncias de classes. 
// Uma classe é um molde ou uma estrutura que define as propriedades e comportamentos de um objeto

// Conceitos principais:
// classe: define um tipo com atributos e métodos.
// objeto: instância de uma classe.
// atributos: dados que descrevem o objeto.
// métodos: ações que o objeto pode executar.
// modificadores de acesso: public, private, protected, internal controlam visibilidade.

// classes são usadas para criar objetos, que são instâncias de uma classe. 
// Objetos possuem atributos (dados) e métodos (comportamentos) definidos pela classe.
/*
var pessoa = new Pessoa("Leonardo", 28);
Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");

var saldo = new ContaBancaria();
saldo.AdicionarSaldo(decimal.Parse("100.00"));
saldo.AdicionarSaldo(decimal.Parse("1000.00"));
//saldo.AdicionarSaldo(decimal.Parse("-1000.00"));
Console.WriteLine($"Saldo: {saldo.Saldo}");

var produto = new Produto("Notebook", decimal.Parse("1000.00"), 10);
Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}, Quantidade: {produto.Estoque}");

var produto2 = new Produto("Mouse", decimal.Parse("50.00"));
Console.WriteLine($"Produto: {produto2.Nome}, Preço: {produto2.Preco}, Quantidade: {produto2.Estoque}");

var produto3 = new Produto();
Console.WriteLine($"Produto: {produto3.Nome}, Preço: {produto3.Preco}, Quantidade: {produto3.Estoque}");
Console.WriteLine(new string('-', 30));
*/

/* Herança é um princípio da orientação a objetos que permite criar uma nova classe (classe derivada) a partir de uma classe existente (classe base). 
A classe derivada herda os atributos e métodos da classe base, podendo adicionar novos atributos e métodos ou modificar os existentes. 
A herança promove a reutilização de código e a criação de hierarquias de classes, facilitando a organização e manutenção do código. 
*/

/*
var cachorro = new Cachorro(nome: "Toby", raca: "Labrador");
Console.WriteLine($"Nome: {cachorro.Nome}, Raça: {cachorro.Raca}");
cachorro.EmitirSom();
*/


/* struct é um tipo de valor, enquanto class é um tipo de referência.
struct é mais leve e geralmente usado para representar dados simples, enquanto class é mais flexível e pode conter métodos, propriedades e eventos. 
struct é alocado na stack, enquanto class é alocado no heap. 
struct não suporta herança, enquanto class suporta herança.
*/

/* 
var a = new PontoClasse { X = 2, Y = 3 };
var b = a;        // b aponta para o MESMO objeto que a
b.X = 10;

Console.WriteLine(a.X);  // 10 — a também mudou!
Console.WriteLine(b.X);  // 10

var p1 = new PontoStruct { X = 2, Y = 3 };
var p2 = p1;      // p2 recebe uma CÓPIA independente
p2.X = 10;

Console.WriteLine(p1.X);  // 2 — p1 não foi afetado
Console.WriteLine(p2.X);  // 10

*/

/*
Record é um tipo de referência imutável, ideal para representar dados que não devem ser alterados após a criação.
Ele é útil para criar objetos de valor, onde a igualdade é baseada no conteúdo dos dados, e não na referência do objeto. 
Record é uma forma concisa de definir classes imutáveis, com suporte a comparação de igualdade baseada em valor e recursos de desestruturação.

//PraticandoRecord.PessoaRecord();

var person = new Person("Leonardo", 28);
var person2 = new Person(person.Name, person.Age);

person.ChangeName("Toby");

Console.WriteLine($"É igual: {person.Equals(person2)}"); // False, pois são objetos diferentes na memória por mais que tenham os mesmos valores

Console.WriteLine(new string('-', 20));
var personRecord = new PersonRecord("Leonardo", 28);
var personRecord2 = personRecord with { Name = "Leonardo" }; // Criando um novo objeto com base em personRecord, mas com o nome modificado
Console.WriteLine($"É igual: {personRecord.Equals(personRecord2)}"); // True, pois são objetos com os mesmos valores na memória, mesmo que sejam objetos diferentes na memória por mais que tenham os mesmos valores

var personRecord3 = personRecord with { Name = "Toby" }; // Criando um novo objeto com base em personRecord, mas com o nome modificado 
Console.WriteLine($"valor de personRecord3: {personRecord3.Name}, Idade: {personRecord3.Age}");
*/