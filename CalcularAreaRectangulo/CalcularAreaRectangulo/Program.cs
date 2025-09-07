// See https://aka.ms/new-console-template for more information

double a, b, c;

Console.WriteLine("Calcular area del rectangulo");
Console.WriteLine("Ingrese el lado A: ");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el lado B: ");
b = Convert.ToDouble(Console.ReadLine());

c = a * b;

Console.WriteLine("El lado A: "+a+" el lado B: "+b+" el resultado: "+c);
