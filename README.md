# INTEGRANTES
- Matheus da Silva dos Anjos
- Karin Pereira da Silva
- Marcelo de Oliveira Cabral Sobrinho

# ESTRUTURA DO PROJETO

## Program.cs
Sobre o uso do Program.cs com menu interativo
Esse código está sendo usado como o centro de controle do projeto. Ele funciona como um menu principal que exibe todas as opções de exercícios que foram desenvolvidos. A ideia é facilitar para o usuário (ou até para nós mesmos durante os testes) na hora de escolher qual parte do programa queremos executar. Assim, em vez de rodar cada exercício separadamente, a gente centraliza tudo num único lugar, usando um menu que aparece no console. Isso é útil tanto para organização quanto para navegação.

### Por que usar esse estilo de código?
Esse estilo com menu é simples e eficiente. Ele usa um laço while que mantém o programa em execução até o usuário escolher a opção de sair (opção 0). Dentro do switch, cada case chama uma função de um exercício diferente, permitindo que o código fique organizado e modularizado. Isso ajuda bastante porque evita que tudo fique misturado e facilita tanto a leitura quanto a manutenção do projeto.

Não está sendo aplicado especificadamente o MVC, porém foi separado de maneira com que ficasse mais compreensível.
## Exercício 1 – Validador de Senha
Esse código serve pra verificar se a senha que o usuário digitou é forte ou fraca. Ele olha se tem pelo menos 8 caracteres, uma letra maiúscula, um número e algum símbolo especial como !, @ ou #. Se a senha tiver tudo isso, ele diz que é uma senha forte; se não tiver, avisa que é fraca. É uma forma simples de simular como sites avaliam senhas.

## Exercício 2 – Tabuada
Aqui o usuário digita um número e o programa mostra a tabuada desse número, de 1 até 10. Ele faz as multiplicações e mostra tudo na tela, tipo "5 x 1 = 5", "5 x 2 = 10" e assim por diante. É bem direto e ótimo pra quem tá começando a aprender laços e lógica de repetição.

## Exercício 3 – Fatorial
Nesse, a pessoa digita um número positivo e o programa calcula o fatorial dele, que basicamente é o número multiplicado por todos os anteriores até 1. Por exemplo, 5! é 5×4×3×2×1. Ele usa um while pra fazer isso e no final mostra o resultado pro usuário.

## Exercício 4 – Conversor de Temperaturas
Esse é um conversor entre Celsius e Fahrenheit. Ele mostra um menu pro usuário escolher se quer converter de Celsius pra Fahrenheit, de Fahrenheit pra Celsius, ou sair. Aí ele faz a conta certa pra cada caso e mostra o valor convertido. É simples e funciona em loop até a pessoa escolher sair.

## Exercício 5 – Verificador de Palíndromo
Esse aqui é legal: ele verifica se a palavra ou frase que a pessoa digitou é um palíndromo, ou seja, se dá pra ler igual de trás pra frente (tipo "arara" ou "Ame a ema"). O programa ignora espaços, pontuações e até maiúsculas, então fica bem justo. Ele trata o texto e compara com a versão invertida. Se forem iguais, ele diz que é palíndromo.

## Exercício 6 – Cadastro de Produtos
Esse programa faz um mini cadastro de 3 produtos. O usuário digita o nome, o preço e a quantidade de cada produto. Depois, o código calcula quanto dá no total de cada item (preço × quantidade) e mostra esse valor na tela. É como se fosse um sistema simples de compras ou controle de estoque.

## Exercício 7 – Soma dos Números Pares
Aqui o usuário digita 10 números, e o programa soma apenas os que são pares. Ele guarda os números num array, verifica se cada um é par (divisível por 2) e vai somando. No final, mostra a soma total dos pares. É um exercício bem prático pra trabalhar for, if e arrays.

## Exercício 8 – Cálculo de IMC
Esse código calcula o famoso IMC. A pessoa informa o peso e a altura, e o programa calcula o índice de massa corporal com a fórmula peso / (altura²). Depois de calcular, ele mostra o resultado e diz em qual faixa a pessoa está: abaixo do peso, normal, sobrepeso ou obesidade. É útil pra entender como classificações funcionam com if e else.

## Exercício 9 – Jogo de Adivinhação
Esse aqui é tipo um joguinho. O computador escolhe um número aleatório de 1 a 100 e o usuário tem que adivinhar. A cada tentativa, o programa diz se o número é maior ou menor. Quando a pessoa acerta, o programa mostra quantas tentativas foram feitas. É divertido e bom pra treinar laços e lógica de comparação.

## Exercício 10 – Lista de Tarefas
Esse é uma versão bem simples de uma To-Do List. A pessoa pode adicionar tarefas e listar o que já foi adicionado. Não tem edição nem exclusão, mas cumpre o básico: registrar uma tarefa e poder ver tudo que foi salvo. Funciona num loop com menu, e as tarefas ficam numa lista. É um bom exercício pra praticar listas, laços e interação com o usuário.


# Exercícios Detalhados  ---------------------------------------------

## EXERCÍCIO N°5
### 1. Lógica de Utilização

O objetivo deste exercício é verificar se uma entrada textual fornecida pelo usuário (palavra ou frase) é um palíndromo — ou seja, se ela pode ser lida da mesma forma de trás para frente, ignorando pontuação, espaços e diferenças entre maiúsculas e minúsculas.

Esse tipo de verificação é muito comum em exercícios de lógica de programação, entrevistas técnicas e atividades educacionais. É uma maneira simples e eficaz de testar habilidades com:

Manipulação de strings;

- Filtros e transformações de dados;

- Comparações lógicas.

### 2. Lógica de Código (Por que foi feito assim?)

O código do exercício 5 segue um raciocínio baseado em transformações progressivas da entrada do usuário para permitir uma comparação justa entre o texto original e sua versão invertida.

Passos da lógica do código:

```
Console.Write("Digite uma palavra ou frase: ");
```
--> Solicita ao usuário a entrada. Isso torna o programa interativo e dinâmico.

```
string entrada = new string(Console.ReadLine()
    .Where(char.IsLetterOrDigit)
    .Select(char.ToLower)
    .ToArray());
```
***--> Explicação por partes:***

```
Console.ReadLine()
```
lê o que o usuário digitou.

```
.Where(char.IsLetterOrDigit)
```
filtra para manter apenas letras e números. Isso ignora espaços e pontuações, o que é essencial para uma verificação correta de palíndromo.

```
.Select(char.ToLower)
```
transforma tudo para minúsculo, eliminando o problema de letras maiúsculas/minúsculas.

```
.ToArray()
```
transforma o resultado em um array de caracteres.

```
new string(...)
```
reconstrói a string filtrada e normalizada.

***Justificativa:*** Essas transformações garantem uma base uniforme para comparação. Duas palavras podem ser palíndromos mesmo que contenham letras maiúsculas ou sinais, então precisamos tratá-las de forma "neutra".

```
string reverso = new string(entrada.Reverse().ToArray());
```
--> Motivação: Essa linha inverte a string tratada, permitindo a comparação direta com a versão original.


```
Console.WriteLine(entrada == reverso ? "É palíndromo!" : "Não é palíndromo.");
```
--> Motivação: Compara as duas versões (original tratada e invertida) e imprime uma resposta intuitiva ao usuário.

### 3. Justificativas Claras do Método
O método adotado para verificar se uma palavra ou frase é um palíndromo foi pensado para ser simples, funcional e fácil de entender. Mesmo sem o uso de LINQ, o código cumpre muito bem o objetivo. Abaixo estão os motivos que justificam as escolhas feitas:

**Eficiência com lógica básica:** 
Ao invés de utilizar bibliotecas externas ou comandos avançados como LINQ, o código se baseia em estruturas fundamentais da linguagem C#, como laços, condicionais e manipulação de strings. Isso o torna mais acessível para quem está aprendendo e, ao mesmo tempo, garante um bom desempenho na execução.

**Clareza no fluxo de execução:** 
O processo segue uma sequência lógica bem definida: primeiro, a entrada do usuário é lida e os caracteres relevantes são isolados (letras e números); depois, todos são convertidos para minúsculas, e por fim a string é comparada com sua versão invertida. Esse passo a passo é fácil de entender e facilita tanto o aprendizado quanto a manutenção do código.

Resumindo, mesmo com recursos básicos, o código é eficiente, confiável e cumpre bem o que se propõe. Ele resolve o problema de forma elegante, didática e com uma base sólida de lógica de programação.


## EXERCÍCIO N°6
### 1. Lógica de Utilização
Este exercício tem como objetivo criar um sistema simples de cadastro de produtos, onde o usuário informa os detalhes de 3 produtos (nome, preço e quantidade), e o sistema calcula e exibe o valor total de cada produto (preço multiplicado pela quantidade).
Passos do Usuário:
- O programa solicita o nome, o preço e a quantidade de três produtos.

- O usuário preenche esses dados para cada produto, um de cada vez.

- O programa, ao final, calcula o valor total de cada produto e exibe esse valor na tela.

Exemplo de Interação com o Usuário:

**Produto 1:**

Nome: "Camiseta"

Preço: 49,99

Quantidade: 3

Total: 149,97

**Produto 2:**

Nome: "Calça"

Preço: 79,90

Quantidade: 2

Total: 159,80

### 2. Lógica de Código (Por que foi feito assim?)
O código segue um fluxo lógico simples e eficaz para capturar dados do usuário, armazená-los e, em seguida, realizar o cálculo e exibição dos resultados.

```
public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;
}
```
Aqui, a classe Produto é criada para modelar um produto com três propriedades essenciais: Nome, Preco e Quantidade. Esses dados são necessários para o cálculo do valor total de cada produto. A classe funciona como um modelo de dados (estrutura) para armazenar as informações de cada produto.

```
Produto[] produtos = new Produto[3];
```
Um vetor (array) de objetos é criado para armazenar três instâncias da classe Produto. O número 3 é fixo, pois o exercício pede para cadastrar exatamente 3 produtos. Cada elemento do array será uma instância da classe Produto, que armazenará as informações de cada item.

```
for (int i = 0; i < 3; i++)
{
    produtos[i] = new Produto();
    Console.Write($"Produto {i + 1} Nome: ");
    produtos[i].Nome = Console.ReadLine();
    Console.Write("Preço: ");
    produtos[i].Preco = double.Parse(Console.ReadLine());
    Console.Write("Quantidade: ");
    produtos[i].Quantidade = int.Parse(Console.ReadLine());
}
```

 O loop for é utilizado para realizar o cadastro de três produtos.

- Em cada iteração, o programa cria um novo objeto da classe Produto e solicita ao usuário o preenchimento das informações de Nome, Preco e Quantidade.

- O método Console.ReadLine() é usado para ler as entradas do usuário. O double.Parse() e int.Parse() convertem as entradas de texto para os tipos de dados apropriados (número decimal para Preco e número inteiro para Quantidade).

```
foreach (var p in produtos)
    Console.WriteLine($"{p.Nome} - Total: R${p.Preco * p.Quantidade:F2}");
```

Motivo: Após o cadastro, o loop foreach percorre cada item do array produtos, exibindo o nome do produto e o total calculado (Preco * Quantidade).

- O cálculo do total é feito diretamente na linha de exibição.

- O formato R${p.Preco * p.Quantidade:F2} garante que o valor total seja exibido com duas casas decimais (como é comum para valores monetários).

### 3. Justificativas Claras para a Compreensão do Método Adotado

**Justificativa para a Estrutura e Utilização da Classe Produto:**
A utilização de uma classe Produto tem como objetivo organizar os dados de cada produto de forma estruturada. Em vez de usar variáveis avulsas, a classe permite que o código seja mais organizado, modular e extensível. Isso é útil, especialmente se o programa for expandido no futuro, por exemplo, para adicionar mais produtos ou funcionalidades.

**Justificativa para o Uso do Array:**
O uso de um array de 3 produtos é uma solução prática e eficiente para armazenar os dados de um número fixo de produtos. Utilizando um vetor (array), temos fácil acesso aos produtos cadastrados, sem a necessidade de declarar variáveis separadas para cada um (o que seria trabalhoso e menos flexível). Além disso, o uso do array permite percorrer todos os produtos com facilidade usando um loop foreach.

**Justificativa para o Loop de Cadastro:**
O loop for foi escolhido para repetir o cadastro três vezes, uma vez para cada produto. O índice i dentro do loop indica qual produto está sendo cadastrado. O código também utiliza leitura dinâmica de dados através do Console.ReadLine(), permitindo que o programa se adapte aos valores inseridos pelo usuário.

**Justificativa para a Exibição de Resultados:**
O loop foreach é utilizado para percorrer todos os produtos cadastrados e exibir suas informações de forma clara. A expressão ${p.Nome} - Total: R${p.Preco * p.Quantidade:F2} usa interpolação de strings para combinar texto e valores variáveis de forma legível e organizada, formatando o valor total com duas casas decimais para a apresentação do preço.
