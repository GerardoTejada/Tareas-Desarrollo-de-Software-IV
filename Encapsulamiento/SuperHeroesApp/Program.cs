// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Text;
using SuperHeroesApp.Models;

// Super Poderes
// 1. Poder volar
var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;
// 2. Super fuerza 
var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

// Super Heroes
var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

var superman2 = new SuperHeroe();
superman2.Id = 1;
superman2.Nombre = "Superman";
superman2.IdentidadSecreta = "Clark Kent";
superman2.Ciudad = "Metropolis";
superman2.PuedeVolar = true;

Console.WriteLine(superman2 == superman);

// Registro
SuperHeroeRecor superHeroeRecor = new SuperHeroeRecor(1, "Superman", "Clark Kent");
SuperHeroeRecor superHeroeRecor2 = new SuperHeroeRecor(1, "Superman", "Clark Kent");

Console.Write(superHeroeRecor == superHeroeRecor2); 
// Lista de poderes de superman 
/*List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;

// -- EJUCION --
try
{
    Console.WriteLine(superman.usarSuperPoderes()); 
} catch (Exception e)
{
    Console.WriteLine($"Error: {e.Message}");
}
*/

enum NivelPoder // Enumreacion 
{
    NivelUno,
    NivelDos,
    NivelTres
}

public record SuperHeroeRecor(int Id,
string Nombre,
string IdentidadSecreta);