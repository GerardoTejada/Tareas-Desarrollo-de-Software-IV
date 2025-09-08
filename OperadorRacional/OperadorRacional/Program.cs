// See https://aka.ms/new-console-template for more information

var (val1, val2, val3) = (10,1,2);

Console.WriteLine("Los valores son: "+val1 +" "+ val2 +" "+ val3); // concatenar variables para mostrarlo

bool resultado = val1 == val2;
Console.WriteLine("Resultado de la comparacion val1 == val2: "+resultado); // Comparacion de variables

bool resultado2 = val1 != val2;
Console.WriteLine("Resultado de la comparacion val1 != val2: " + resultado2); // Si hay diferencia entre los valores

bool resultado3 = val1 > val2;
Console.WriteLine("Resultado de la comparacion val1 > val2: " + resultado3); // Si valor 1 es mayor que valor 2

bool resultado4 = val1 < val2;
Console.WriteLine("Resultado de la comparacion val1 < val2: " + resultado4); // Si valor 1 es menos que valor 2

bool resultado5 = val1 >= val2;
Console.WriteLine("Resultado de la comparacion val1 >= val2: " + resultado5); // Si valor 1 es mayor e igual que valor 2

bool resultado6 = val1 <= val2;
Console.WriteLine("Resultado de la comparacion val1 <= val2: " + resultado6); // si valor 1 es menor o igual que valor 2