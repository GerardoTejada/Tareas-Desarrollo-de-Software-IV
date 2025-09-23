using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PRACTICA.Clases
{
    internal class Objeto
    {
        // ATRIBUTOS 
        int id;
        public string name;
        public Objeto(int id, string name) // metodo constructor 
        {
            this.id = id;
            this.name = name;
        }
        // METODOS
        public void verID()
        {
            Console.WriteLine($"{id}");
        }
        public void verName()
        {
            Console.WriteLine($"{name}");
        }


    }
}
