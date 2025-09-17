// See https://aka.ms/new-console-template for more information
// 1. string.Concat();
using System.Text;

string tx1 = "Bitín"; string tx2 = "Explorador";
Console.WriteLine(string.Concat(tx1," ", tx2)); // Concatenar tx1, un espacio libre y tx2

Console.WriteLine("==============================02===================================");
//2. string.join();
string result;  // Variable para guardar resultado 
/* cuento */ string[] cuentoArray = { "Bitín era un explorador curioso que vivía en un pequeño pueblo", 
    " Un día decidió salir al mundo para buscar un tesoro", 
    " Al final del viaje, comprendió que el verdadero tesoro eran las historias que había vivido "};

result = string.Join("|", cuentoArray); // empatar cada oracion con |
Console.WriteLine(result); // Mostrar el resultado
Console.WriteLine("==============================03===================================");

//3. string.Format();
/* cuento */ string cuentoCadena = "Bitín era un explorador curioso que vivía en un pequeño pueblo. Un día decidió salir al mundo para buscar un tesoro escondido entre montañas y ríos. \r\nEl camino no fue fácil: encontró mapas con ceros y unos que parecían acertijos imposibles de descifrar. \r\nSin embargo, su meta era clara y nunca se rindió. \r\nAl final del viaje, Bitín comprendió que el verdadero tesoro no eran las monedas ni los ceros dibujados en los mapas, sino las historias que había vivido.";
string[] palabraDiv = cuentoCadena.Split(" "); // Cantidad de palabras
int palabrasTotal = palabraDiv.Length;
int caracteresTotal = cuentoCadena.Length; // Cantidad de caracteres
Console.WriteLine(string.Format("El cuento tiene {0} caracteres y {1} palabras",caracteresTotal,palabrasTotal));
Console.WriteLine("==============================04===================================");
// 4. string.Interpolation($"");
string nombre = "Bitín"; string meta = "un tesoro";
Console.WriteLine($"El protagonista es {nombre} y busca {meta}");
Console.WriteLine("==============================05===================================");
// 5. Convert.toString
int longitudCuento = cuentoCadena.Length; // Calcular la longitud del cuento
string strNum = Convert.ToString(longitudCuento); // Convertir los entero a string
Console.WriteLine(string.Concat("Longitud del cuento: ",strNum));
Console.WriteLine("==============================06===================================");
// 6. indexOf();
int index = cuentoCadena.IndexOf("mundo");
Console.WriteLine("La palabra 'mundo' se encuentra en la posicion: {0}",index);
Console.WriteLine("==============================07===================================");
// 7. LastIndexOf()
int lastIndexOf = cuentoCadena.LastIndexOf("ceros"); // Calcular la ultima vez que dice ceros en el cuento
Console.WriteLine($"La palabra 'ceros' aparace ultima vez en: {lastIndexOf}");
Console.WriteLine("==============================08===================================");
//8. Contians()
bool cuentoContains = cuentoCadena.Contains("Nube");
Console.WriteLine($"¿Esta la palabra 'Nube' en el cuento?: {cuentoContains}");
Console.WriteLine("===============================09==================================");
// 9. StarWith()
string confirmarInicio = "En el vasto universo";
bool cadenaStart = cuentoCadena.StartsWith(confirmarInicio); // Se verifica si inicia con En el vasto universo
Console.WriteLine($"¿El cuento inicia con {confirmarInicio}?: {cadenaStart}"); // Mostrar respuesta
Console.WriteLine("===============================10==================================");
// 10. EndsWith()

string terminaCon = "ceros y unos"; 
Console.WriteLine(cuentoCadena.EndsWith(terminaCon)); // Se verifica y se muestra
Console.WriteLine("================================11=================================");
//11. Substring();
int indicePalabra = cuentoCadena.IndexOf("explorador curioso");
int tamañoPalabra ="explorador curioso".Length; // extraer la longitud de la palabra
Console.WriteLine("Substring cuento: "+cuentoCadena.Substring(indicePalabra,tamañoPalabra)); // Primero se extrae el indice de la palabra explorador curioso, despues se extrae usando SubString usando su indice
Console.WriteLine("================================12===============================");
// 12. Remove().

Console.WriteLine(cuentoCadena.Remove(0,15));
Console.WriteLine("==================================13===============================");
// 13. Replace();
// Sustituye todas las apariciones de “Bitín” por “ProgramaX”.
Console.WriteLine(cuentoCadena.Replace("Bitín","ProgramaX"));
Console.WriteLine("==================================14===============================");
// 14. Insert()

// Inserta la palabra “(IMPORTANTE)” después de la palabra “firewall”. (en mi caso despues de "tesoro")
int indexTesoro = cuentoCadena.IndexOf("tesoro") + "tesoro".Length + 1; // Se busca el indice final de la palabra tesoro en el cuento
Console.WriteLine(cuentoCadena.Insert(indexTesoro, "(IMPORTANTE) "));
Console.WriteLine("===================================15==============================");
// 15. PadLeft()
// Rellena la palabra “Bitín” a la izquierda con ‘*’ hasta tener 10 caracteres.
Console.WriteLine("Bitín".PadLeft(10,'*'));
Console.WriteLine("===================================16==============================");
// 16. PadRight()
// Rellena la palabra “Nube” a la derecha con ‘-’ hasta tener 12 caracteres.
Console.WriteLine("Nube".PadRight(12,'-'));
Console.WriteLine("===================================17==============================");
//17. trim();
// Toma un fragmento con espacios extras (“ firewall ”) y elimina los espacios. (En mi caso " tesoro  ")
string fragmento = "  tesoro  ";
Console.WriteLine("Fragmento con espacio: "+fragmento+ "\nFragmento sin espacios:"+fragmento.Trim());
Console.WriteLine("===================================18==============================");
// 18. TrimStart()
// Elimina solo los espacios iniciales de la frase “ Mundo binario”.
fragmento = " Mundo binario";
Console.WriteLine("Fragmento con espacio: " + fragmento + "\nFragmento sin espacios iniciales:" + fragmento.TrimStart());
Console.WriteLine("===================================19==============================");
// 19. TrimEnd()
// Elimina solo los espacios finales de la frase “Bitín explorador ”.
fragmento = "Bitín explorador ";
Console.WriteLine("Fragmento con espacio: " + fragmento +". "+ "\nFragmento sin espacios iniciales: " + fragmento.TrimEnd()+ ".");
Console.WriteLine("===================================20==============================");
//20. Split()
// Divide el cuento en palabras individuales y muestra las primeras 10.
string[] diezPalabras = cuentoCadena.Split(" "); // Dividir las palabras
for (int i = 0; i < 10; i++) // Imprimir las 10 primera palabras 
{
    Console.Write($"({i+1}) {diezPalabras[i]} ");
}
Console.WriteLine("\n ===================================21==============================");
// 21. Equals()
// Verifica si la palabra “Bitín” es igual a “bitín” sin importar mayúsculas.
Console.WriteLine($"¿Son iguales “Bitín” y “bitín”?: {Equals("Bitín", "bitín")} ");
Console.WriteLine("\n ===================================22==============================");
// 22. Compare()
// Compara las palabras “Explorador” y “explorador” y muestra el resultado numérico.
Console.WriteLine($"Comparacion entre “Explorador” y “explorador”: {string.Compare("Explorador", "explorador")}");
Console.WriteLine("\n ===================================23==============================");
// 23. CompareOrdinal()
// Compara las palabras “Nube” y “Nodo” de manera ordinal.
Console.WriteLine($"Comparacion “Nube” y “Nodo” de manera ordinal: {"Nube".CompareTo("Cielo")}");


Console.WriteLine("\n ===================================24==============================");
// 24. IsNullOrEmpty()
// Declara una cadena vacia y verifica si lo es
string empt = "";
Console.WriteLine("Es vacia? "+string.IsNullOrEmpty(empt));
Console.WriteLine("\n ===================================25==============================");
// 25. isNullOrWhiteSpace
// Declara una cadena con solo espacios y valida el resultado
empt = " ";
Console.WriteLine("Hay solo espacios?: ´"+string.IsNullOrWhiteSpace(empt));
Console.WriteLine("\n ===================================26==============================");
// 26. ToLower()
//Convierte todo el cuento a minúsculas y muestra un fragmento.
Console.WriteLine(cuentoCadena.ToLower());

Console.WriteLine("\n ===================================27==============================");
// 27. ToUpper()
// Convierte todo el cuento a mayúsculas y muestra un fragmento.
Console.WriteLine(cuentoCadena.ToUpper());

Console.WriteLine("\n ===================================28==============================");
// ToLowerInvariant()
Console.WriteLine("NUBE".ToLowerInvariant());

Console.WriteLine("\n ===================================29==============================");
// ToUpperInvariant()
Console.WriteLine("bitín".ToUpperInvariant());