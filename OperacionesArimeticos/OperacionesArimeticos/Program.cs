// See https://aka.ms/new-console-template for more information
var a = 0d; var b = 0d; var c = 0d; // Cambios a 0d;


Console.WriteLine("Calcular area del rectangulo");
Console.WriteLine("Ingrese el lado A: ");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el lado B: ");
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


c = a * b;
double d = a / b;
double e = (a * c/2);
double f = (a % b);

Console.WriteLine("El lado A: " + a + " el lado B: " + b + " el resultado: " + c);
Console.WriteLine("El resultado en division: "+c);
Console.WriteLine("El resultado entre dos: "+e);
Console.WriteLine("El resultado en porcentaje: "+f);