// See https://aka.ms/new-console-template for more information

int totalJugador = 0;
string message = "";
int totalDealer = 15;
string control = "";
// Blackjack, Juntar 21 pidiendo cartas o
// caso de tener menos de 21 tener mayor puntuacion
// que el dealer

Console.WriteLine("Bienvenido al Casino");
Console.WriteLine("Escriba '21' para jugar al 21");
control = Console.ReadLine();

switch (control)
{
    case "21":
        Console.WriteLine("Escriba un numero: ");
        totalJugador = Convert.ToInt32(Console.ReadLine());

        if (totalJugador > totalDealer && totalJugador < 22)
        {
            message = "Venciste al dealer, felicidades";
        }
        else if (totalDealer >= totalJugador)
        {
            message = "Perdiste vs el dealer, lo siento";
        }
        else
        {
            message = "Condicion no valido"; // Condicion invalida cuando el jugador tiene mayor que 22
        }
        Console.WriteLine(message);
        break;
    default:
        Console.WriteLine("Condicion invalida");
        break;
}


