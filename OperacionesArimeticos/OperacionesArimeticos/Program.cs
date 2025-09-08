// See https://aka.ms/new-console-template for more information
var a = 0d; var b = 0d; var c = 0d; // Cambios a 0d;


Console.WriteLine("Calcular area del rectangulo");
Console.WriteLine("Ingrese el lado A: "); // Entrada del lado A
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el lado B: "); // Entrada del lado B
b = Convert.ToDouble(Console.ReadLine());
/*
a++; // Operador de incremento
a--; // Operador de decremento
*/
/*
a = a + 1; // similar al operador incremento
a = a - 1; //Similar al operador de decremento
*/

/*
a++;
a++;
a++;
a++;
*/


c = a * b; // Multiplicacion
double d = a / b; // Division
double e = (a * c/2); // Multiplicacion primero y despues dividir 
double f = (a % b); // Porcentaje

// Salidas
Console.WriteLine("El lado A: " + a + " el lado B: " + b + " el resultado: " + c); // multiplicacion
Console.WriteLine("El resultado en division: "+d); // Division
Console.WriteLine("El resultado entre dos: "+e); // Multiplicacion y division
Console.WriteLine("El resultado en porcentaje: "+f); // Porcentaje