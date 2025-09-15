// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

int totalJugador = 0;
string message = "";
int totalDealer = 0;
string control = ""; // Controla la direccion del switch
string controlWhile = ""; // Controla la repeticion de cartas
bool gameControl = true; // control del bucle del juego
bool controlInput = true;
Random random = new Random(); // Clase para la funcion de random
// Blackjack, Juntar 21 pidiendo cartas o
// caso de tener menos de 21 tener mayor puntuacion
// que el dealer



// Proceso
while (gameControl)
{
    if (controlInput)
    {
        Console.WriteLine("Bienvenido al Casino");
        Console.WriteLine("Escriba '21' para jugar al 21"); // Pide el string 21 para comenzar
        control = Console.ReadLine();
    }

    switch (control)
    {
        case "21":
            Console.WriteLine("El dealer a tomado sus cartas \n");
            totalDealer = random.Next(14, 23); // Cartas aleatorias al dealer
            do
            { // Bucle en donde el usuario recibe cartas entre 1 al 12

                totalJugador += +random.Next(1, 12);
                Console.WriteLine($"Esta es su total de cartas: {totalJugador}");
                Console.WriteLine("Desea otra cara?");
                controlWhile = Console.ReadLine().ToLower(); // Tomar la respuesta si a todo minusculas
                System.Console.Clear();  // Limpia la consola
            } while (controlWhile == "si" || controlWhile == "yes"); // Sale cuando el usuario diga no

            if (totalJugador > totalDealer && totalJugador < 22) // Si el numero es mayor que el dealer pero menor que 22 
            {
                message = $"Venciste al dealer, el dealer tenia {totalDealer}";
            }
            else if (totalDealer >= totalJugador) // Si el dealer su valores son mayores que el del jugador 
            {
                message = $"Perdiste, el dealer tenia {totalDealer}";
            }
            else
            {
                message = "Te has pasado de la cantidad limite de cartas!"; // Condicion invalida cuando el jugador tiene mayor que 22
            }
            // Salida valida o invalida
            Console.WriteLine(message);
            break;
        default:
            Console.WriteLine("Condicion invalida");
            break;
    }
    controlInput = false; // se desactiva la entrada para jugar
    Console.WriteLine("¿Deseas salir? si/no: "); // Control de terminacion del juego 
    string controlG = Console.ReadLine().ToLower();
    if (controlG.Equals("si"))
    {
        gameControl = false;
    }
    else if (controlG.Equals("no"))
    {
        // Resetear datos
        controlInput = true;
        totalJugador = 0;
        message = "";
        totalDealer = 0;
        control = "";
        controlWhile = "";
        gameControl = true;
    }
    else
    {
        Console.WriteLine("dato invalido");
    }
}

