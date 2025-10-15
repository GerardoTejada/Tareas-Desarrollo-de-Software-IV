using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace parcial2poo.Clases
{
    internal class Materia
    {
        private string nombre;
        private string codigo;
        private int creditos;
        private int cupos;
        private int inscritos;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.Trim(); }
        }

        public string Codigo { get { return codigo; } set { codigo = value.Trim(); } }
        public int Creditos { get { return creditos; } 
            set 
            { 
                if (value >= 0)
                {
                    creditos = value;
                } 
            } 
        }
        public int Cupos { get { return cupos; } 
            set 
            { 
                if(value >= 0)
                {
                    cupos = value;
                } else
                {
                    Console.WriteLine("Los cupos son invalidos");
                }
            } 
        }
        public int Inscritos { get {return inscritos; } 
        set
            {
                if (value >= 0 && value <= Cupos)
                {
                    inscritos = value;
                } else
                {
                    Console.WriteLine("Los incritos son invalidos");
                }
            }
        }

        public Materia(string nom, string cod, int cred, int cup, int insc)
        {
            Nombre = nom;
            Creditos = cred;
            Codigo = cod;
            Cupos = cup;
            Inscritos = insc;
        }

        public Materia() { }

        public int CalcularCargarSemanal(int horasPorCredito)
        {
            return Creditos * horasPorCredito;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}, Creditos: {Creditos}, cupos{Cupos}, Inscritos {Inscritos}");
        }
    }
}
