// See https://aka.ms/new-console-template for more information


// Declaracion de variables de Ricardo Perez
Console.WriteLine("Ricardo Perez ID");
int altura = 168; int edad = 89; string nombre = "Ricardo Perez"; string informacion = "Nacio en hidalgo " +
    "es estudiante de gastronomia y astronomia";
var hobby = "deportista";

// Mostrar mensaje de la tarjeta de identificacion de Ricardo Perez

string tarjetaDeIdentificacion = $"La informacion de {nombre} \n es la siguiente, " +
    $"su edad son {edad} \n " +
    $"años, su altura {altura} \n " +
    $"Informacion relevante {informacion} " +
    $"\n ademas, su hobby es {hobby}";

Console.WriteLine(tarjetaDeIdentificacion);

