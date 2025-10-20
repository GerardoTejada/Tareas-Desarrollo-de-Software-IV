using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace parcial2poo.Clases
{
    internal class Calificacion : IMostrable
    {
        private Estudiante estudiante;
        private Materia materia;
        private double nota; // Rango entre 0-100

        public Estudiante Estudiante { get { return estudiante; } set { estudiante = value; } }
        public Materia Materia { get { return materia; } set { materia = value; } }
        public double Nota { get { return nota; } set 
            { 
                if(0 <= value && value <= 100)
                {
                    nota = value;
                }
            } 
        }

        public Calificacion(Estudiante est, Materia mat, double not)
        {
            Estudiante = est;
            Materia = mat;
            Nota = not;
        }

        public double CalcularPuntos()
        {
            return Nota * Materia.Creditos;
        }
            

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Estudiante}, Materia: {Materia}, nota: {Nota}");
        }
    }
}
