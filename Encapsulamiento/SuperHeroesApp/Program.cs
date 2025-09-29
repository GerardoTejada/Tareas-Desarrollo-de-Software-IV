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

// 3. Regeneracion
var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneracion";
regeneracion.Nivel = NivelPoder.NivelTres;


// Super Heroes
var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "    Superman    ";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

var superman2 = new SuperHeroe();
superman2.Id = 1;
superman2.Nombre = "Superman";
superman2.IdentidadSecreta = "Clark Kent";
superman2.Ciudad = "Metropolis";
superman2.PuedeVolar = true;

// Registro
SuperHeroeRecor superHeroeRecor = new SuperHeroeRecor(1, "Superman", "Clark Kent");
SuperHeroeRecor superHeroeRecor2 = new SuperHeroeRecor(1, "Superman", "Clark Kent");

// Lista de poderes de superman 
List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;

// Anti heroe 
var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "logan";
wolverine.PuedeVolar = false;

// Poderes wolverine 
List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);
wolverine.SuperPoderes = poderesWolverine;
// -- EJUCION --
try
{
    Console.WriteLine(superman.usarSuperPoderes()); 
    Console.WriteLine(wolverine.usarSuperPoderes());
    Console.WriteLine(wolverine.RealizarAccionDeAntiHeroe("Ataca a la policia"));
    Console.WriteLine(superman.SalvarElMundo());
    Console.WriteLine(superman.SalvarLaTierra());
    var imprimir = new SuperHeroesApp.ImprimirInfo();
    imprimir.ImprimirSuperHeroe(superman);
    imprimir.ImprimirSuperHeroe(wolverine);
} catch (Exception e)
{
    Console.WriteLine($"Error: {e.Message}");
}

enum NivelPoder // Enumreacion 
{
    NivelUno,
    NivelDos,
    NivelTres
}

public record SuperHeroeRecor(int Id,
string Nombre,
string IdentidadSecreta);

namespace SuperHeroesApp
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"Id: {superHeroe.Id} \n" +
                $"Nombre: {superHeroe.Nombre}\n" +
                $"Identidad secreta {superHeroe.IdentidadSecreta}");
        }
    }
}