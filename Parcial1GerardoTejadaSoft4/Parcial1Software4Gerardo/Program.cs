// See https://aka.ms/new-console-template for more information
int opSwitch;
int a, b,d;
Boolean x, y ,z;
const double pi = 3.1416; // Constante de PI
double radio;
string inp; // Contraseña a ingresar
string contraseña = "clave123"; //Contraseña real

do
{
    try
    {
        Console.WriteLine("1. Expresiones arimeticas \n" +
            "2. Operadores de incremento/decremento \n" +
            "3. Operadores relacionales \n" +
            "4. Operadores lógicos\n" +
            "5. Uso de constantes\n" +
            "6. Concatenación e interpolación de strings\n" +
            "7. Bucles (while y for)\n" +
            "8. Salir \n" +
            "Eliga menu (Numero entero ): ");
        opSwitch = Convert.ToInt32(Console.ReadLine());

        switch (opSwitch)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("1. Expresiones arimeticas");
                Console.WriteLine("Ingrese valor 1: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese valor 2: ");
                b = Convert.ToInt32(Console.ReadLine());
                double c = a / b;
                Console.WriteLine($"Resultado: Suma: {a + b} resta: {a - b} multiplicacion: {a * b} division: {c} residuo: {a % b}");
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("2. Operadores de incremento/decremento");
                Console.WriteLine("Ingrese valor 1: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Resultado: incremento: {++a} decremento: {--a}");
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("3. Operadores relacionales");
                Console.WriteLine("Ingrese valor 1: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese valor 2: ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Resultado: Son iguales: {a == b}, son distintos: {a != b}, A es mayor B: {a > b}, " +
                    $"A es menor a B: {a < b}, A es mayor o igual a B: {a >= b}, A es menor o igual a B: {a <= b}");
                break;
            case 4:
                Console.Clear();
                Console.Clear();
                Console.WriteLine("4. Operadores lógicos");
                Console.WriteLine("True/False");
                Console.WriteLine("Ingrese valor 1 (Booleanos): ");
                x = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Ingrese valor 2:(Booleanos) ");
                y = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Ingrese valor 3:(Booleanos) ");
                z = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine($"Resultado: AND {x && y && z}, OR {x || y || z}, !(AND): {!(x && y && z)}, ^: {(x ^ y ^ z)}");
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("6. Concatenación e interpolación de strings");
                Console.WriteLine("Ingrese su nombre: ");
                string n = Console.ReadLine();
                Console.WriteLine("Ingrese su apellido: ");
                string ap = Console.ReadLine();
                Console.WriteLine("Ingrese su edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Resultado: Concatenacion con +:");
                Console.WriteLine(n + " " + ap + "tiene: " + edad + " años");
                Console.WriteLine($"Resultado: Concatenacion con interpolacion:");
                Console.WriteLine($"{n} {ap} tiene {edad} años");
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("5. Uso de constantes");
                Console.WriteLine("Ingrese el radio del circulo: ");
                radio = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Resultado: {pi * (radio * radio)}");
                break;
            case 7:
                Console.Clear();
                Console.WriteLine("7. Bucles (while y for)");
                Console.WriteLine("Imprimirlos numeros del 1 al 10");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }


                Console.WriteLine("Ingrese la contraseña: ");
                inp = Console.ReadLine().Trim();

                while (contraseña != inp)
                {
                    Console.Clear();
                    Console.WriteLine("Contraseña incorrecta. ingrese denuevo: ");
                    inp = Console.ReadLine().Trim();
                }
                Console.WriteLine("Contraseña correcta");
                break;
            case 8:
                return;
                break;
            default:
                Console.Clear();
                Console.WriteLine("Ingrese valor correcto");
                break;
        }

    }
    catch (Exception e)
    {
        Console.Clear();
        Console.WriteLine($"{e.Message}");
    }
} while (true);

