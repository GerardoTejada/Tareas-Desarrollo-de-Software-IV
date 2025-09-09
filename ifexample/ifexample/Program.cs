// See https://aka.ms/new-console-template for more information

int totalJugador = 24;
string message = "";
int totalDealer = 15;
// Blackjack, Juntar 21 pidiendo cartas o
// caso de tener menos de 21 tener mayor puntuacion
// que el dealer

if (totalJugador > totalDealer && totalJugador < 22)
{
    message = "Venciste al dealer, felicidades";
} 
else if (totalDealer  >= totalJugador) 
{
    message = "Perdiste vs el dealer, lo siento";
}
else
{
    message = "Condicion no valido"; // Condicion invalida cuando el jugador tiene mayor que 22
}
    Console.WriteLine(message);
