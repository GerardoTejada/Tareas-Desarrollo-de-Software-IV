// See https://aka.ms/new-console-template for more information

int totalJugador = 0;
string message = "";
int totalDealer = 15;
string control = "";
// Blackjack, Juntar 21 pidiendo cartas o
// caso de tener menos de 21 tener mayor puntuacion
// que el dealer

Console.WriteLine("Bienvenido al Casino");
Console.WriteLine("Escriba '21' para jugar al 21"); // Pide el string 21 para comenzar
control = Console.ReadLine();

// Proceso
switch (control)
{
    case "21":
        Console.WriteLine("Escriba un numero: ");
        totalJugador = Convert.ToInt32(Console.ReadLine()); // Pide un numero 

        if (totalJugador > totalDealer && totalJugador < 22) // Si el numero es mayor que el dealer pero menor que 22 
        {
            message = "Venciste al dealer, felicidades";
        }
        else if (totalDealer >= totalJugador) // Si el dealer su valores son mayores que el del jugador 
        {
            message = "Perdiste vs el dealer, lo siento"; 
        }
        else
        {
            message = "Condicion no valido"; // Condicion invalida cuando el jugador tiene mayor que 22
        }
        // Salida valida o invalida
        Console.WriteLine(message);
        break;
    default:
        Console.WriteLine("Condicion invalida");
        break;
}


