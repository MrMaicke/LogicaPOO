// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// CamalCase = nomeVariavel
// PascalCase = NomeVariavel
//snack_case = nome_variavel

//tipoDeDado nomeVariavel = valorDaVariavel
string nome = "Marcelo Santiago de Oliveira";

int numeroInteiro = 1;

double preco = 5.60D;

float Altura = 1.80f;

bool boleanos = true;

char character = 'A';

Console.WriteLine(nome);

/*----------------------------------------*/

Console.WriteLine("Soma :" + (1 + 2));
Console.WriteLine("Subtração :" + (1 - 2));
Console.WriteLine("Divisão :" + (1 / 2));
Console.WriteLine("Multiplicação :" + (1 * 2));
/*----------------------------------------*/


// = atribuição
//== comparação
//=== comparar valor e tipo

// Operador de igualdade (==)
// Comparar se valores são iguais
Console.WriteLine(5 == 5);

// Operador de diferença (!=)
// Comparar se valores não são iguais
Console.WriteLine(5 != 5);

// Operador de maior (>)
// Comparar se um valor é maior do que o outro
Console.WriteLine(8 > 4);

// Operador de menor que (<)
// Comparar se um valor é menor que o outro
Console.WriteLine(4 < 8);

// Operador de maior ou igual (>=)
// comparar se um valor é maior ou igual
Console.WriteLine(8 >= 4);

// Operador de menor ou igual (<=)
// comparar se um valor é maior ou igual
Console.WriteLine(4 <= 8);


/*----------------------------------------*/

/* OPERADORES LÓGICOS */
// && (e) -- || (ou)
// ! (não/negativa)

Console.WriteLine(5 == 5 && 8 == 8); // true && true (true)

Console.WriteLine(5 == 5 && 18 == 8); // true && false (false)

Console.WriteLine(5 == 15 && 18 == 8); // false && false (false)


Console.WriteLine(2 == 2 || 3 == 3); // true || true (true)

Console.WriteLine(2 == 4 || 3 == 3); // false || true (true)

Console.WriteLine(2 == 4 || 3 == 9); // false || false (false)


console.WriteLine(!true == true);

console.WriteLine(!(2 == 2 || 3 == 3));

/*----------------------------------------*/

bool noite = true;

//se naose
if(noite){
    console.WriteLine("Agora é noite");
}
else{
    console.WriteLine("Agora é de dia");
}

//if ternario
var condicao = (noite) ? "Agora é de noite!" : "Agora é de dia";

var idade = 20;

if (idade < 18 ){
    console.WriteLine("Pessoa menor de idade");
}
else if(idade >= 18 && idade < 21){
    console.WriteLine("Maior de idade mas não de maioridade penal");
}
else
{
    console.WriteLine("Maior de idade legal");
}

switch(diaSemana)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda-feira");
        break;
    case 3:
        Console.WriteLine("Terça-feira");
        break;
    case 4:
        Console.WriteLine("Quarta-feira");
        break;
    case 5:
        Console.WriteLine("Quinta-feira");
        break;
    case 6:
        Console.WriteLine("Sexta-feira");
        break;
    case 7:
        Console.WriteLine("Sabado-feira");
        break;
    default:
        Console.WriteLine("Dia da semana invalido");
        break;
}

/*----------------------------------------*/

/* Enquanto == While -> Laço de repetição */
int numero = 1;

while (numero < 10)
{
    console.WriteLine(numero);
    numero = numero + 1; //numero++
}

int numero02 = 1;

do{
    console.WriteLine(numero02);
    numer02 = numero02 + 1; // numero++
}while (numero02 < 10);

/*for(valor inicial; condição; processamento;)*/
for(int valor = 0; valor < 10; valor++){
    console.WriteLine(valor);
}