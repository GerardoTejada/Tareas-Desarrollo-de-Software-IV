// See https://aka.ms/new-console-template for more information

double a, b, c; // Declaracion de varibles 

Console.WriteLine("Calcular area del rectangulo"); // Titulo
Console.WriteLine("Ingrese el lado A: "); // Entrada del lado a del rectangulo
a = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine("Ingrese el lado B: "); // Entrada del lado b del rectangulo
b = Convert.ToDouble(Console.ReadLine());

c = a * b; // Operacion o calculo 

Console.WriteLine("El lado A: "+a+" el lado B: "+b+" el resultado: "+c); // Salida de la respuesta
