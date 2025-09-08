// See https://aka.ms/new-console-template for more information

var radio = 0d; // La letras sirven para declarar el tipo de variables cuando es Var
var resultado = 0d;

const double Pi = 3.1416;
Console.WriteLine("Calcular area del circulo");
// PI * radio* radio

Console.WriteLine("Ingrese el radio del circulo: "); // Entrada del radio
radio = Convert.ToDouble(Console.ReadLine());

resultado = Pi * (radio * radio); // Operacion o calculo 

Console.WriteLine("El resultado es: "+resultado); // Salida de la respuesta 
