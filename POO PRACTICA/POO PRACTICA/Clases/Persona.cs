using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PRACTICA.Clases
{
    class Persona
    { 
        // ATRIBUTOS DE CADA PERSONA
        string nombre;
        short edad;
        genero genero;
        List<Objeto> Bolsa = new List<Objeto>();
        public Persona(string nombre, short edad, genero genero, List<Objeto> Bolsa) // METODO CONSTRUCTOR s
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
            this.Bolsa = Bolsa;
        }
        
        // METODOS 
        public void caminarAct()
        {
            Console.WriteLine($"{nombre} esta caminando...");
        }

        public void verObjs()
        {
            foreach(Objeto objeto in Bolsa)
            {
                Console.WriteLine($"{nombre} tiene en su bolsa: {objeto.name}");
            }
        }

        public void verDescripcion()
        {
            Console.WriteLine($"{nombre} tiene {edad} su genero es {genero}");
        }

        public void getName()
        {
            Console.WriteLine($"{nombre}");
        }
    }

    enum genero // ENUMERACINO PARA CADA GENERO
    {
        hombre, mujer
    }
}
