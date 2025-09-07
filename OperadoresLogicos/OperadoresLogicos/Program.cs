// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var (valor1, valor2, valor3) = (true,true,false);
 
bool result = valor1 && valor2 && valor3;
Console.WriteLine("Resultado de la comparacion de AND: "+result);

bool result2 = valor1 || valor2 || valor3;
Console.WriteLine("Resultado de la comparacion de OR: " + result2);

bool result3 = (valor1 && valor2) || valor3;
Console.WriteLine("Resultado de la c  omparacion de AND y OR: " + result3);

bool result4 = !valor1;
Console.WriteLine("Resultado de la c  omparacion de NOT: " + result4);

bool resultXor = (valor1 ^ valor2) ^ valor3;
Console.WriteLine("Resultado de la c  omparacion de XOR: " + resultXor);