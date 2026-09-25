# Variáveis e Tipos de dados

Este tópico apresenta os principais tipos de dados em C# e como usá-los em variáveis.

Tipos comuns e quanto armazenam:
- `string`: armazena texto. Não tem limite fixo prático, depende da memória disponível. Use para nomes, frases, mensagens.
- `int`: valores inteiros de -2.147.483.648 a 2.147.483.647. Use para contagens, índices e valores inteiros moderados.
- `long`: valores inteiros de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807. Use quando `int` não for suficiente, como em contadores grandes ou timestamps em milissegundos.
- `float`: numérico de ponto flutuante simples, aproximadamente 7 dígitos de precisão. Use para medidas com menor precisão ou cálculos onde desempenho importa.
- `double`: numérico de ponto flutuante com aproximadamente 15-16 dígitos de precisão. Use para cálculos científicos e valores reais mais comuns.
- `decimal`: numérico de alta precisão para valores financeiros, com 28-29 dígitos de precisão.
- `bool`: somente `true` ou `false`. Use para decisões, flags e condições.
- `char`: único caractere Unicode. Use para letras individuais, símbolos ou caracteres especiais.

Quando usar cada um:
- `string`: armazenar nomes, textos e mensagens.
- `int`: usar em contadores, idades, quantidades e laços de repetição.
- `long`: quando dados podem ultrapassar o limite do `int`.
- `float`/`double`: valores decimais, medições, cálculos matemáticos.
- `decimal`: moeda, cálculos financeiros e valores monetários.
- `bool`: teste de verdadeiro/falso, controle de fluxo.
- `char`: caracteres individuais e manipulação de texto em nível de caractere.

Exemplo:
```csharp
string nome = "Ana";
int idade = 25;
long populacao = 7800000000;
float temperatura = 36.5f;
double precoMedia = 12.75;
decimal valorTotal = 199.99m;
bool ativo = true;
char sexo = 'F';

Console.WriteLine($"Nome: {nome}");
```
