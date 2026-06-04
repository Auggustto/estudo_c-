
using Introducao.FuncoesMetodos;
using Introducao.EstruturasDeControles;
using Introducao.LacosDeRepeticao;
using Introducao.ArraysForeach;

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
*/


// Estruturas de controle são blocos de código que controlam o fluxo de execução do programa. 
// Elas permitem que você execute diferentes blocos de código com base em condições específicas ou repita um bloco de código várias vezes.
/*
PraticandoEstruturasDeControles.EstruturaIf(10);
PraticandoEstruturasDeControles.EstruturaSwitch("Domingo");
*/

// Laços de repetição são usados para executar um bloco de código várias vezes, enquanto uma condição for verdadeira.
var nomes = new List<string> { "Alice", "Bob", "Charlie" };

Console.WriteLine(PraticandoLacosDeRepeticao.EstruturaFor(nomes));
Console.WriteLine(PraticandoLacosDeRepeticao.EstruturaWhile(nomes));
Console.WriteLine(PraticandoLacosDeRepeticao.EstruturaDoWhile(nomes));


// O foreach é uma estrutura de controle que permite iterar sobre os elementos de uma coleção, como arrays ou listas, de forma mais simples e legível. 
// Ele é especialmente útil quando você não precisa acessar os índices dos elementos, mas apenas os valores.
ArraysForeach.Executar(nomes);