using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2poo.Clases
{
    internal class Estudiante : IMostrable
    {
        private string nombre;
        private string id;
        private string carrera;
        private List<Calificacion> calificaciones = new();

        public string Nombre 
        {
            get 
            {
                return nombre;
            }

            set
            {
                nombre = value.Trim();
            }
        }

        public string Id
        {
            get { return id; }
            set { id = value.Trim(); }
        }

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value.Trim(); }  
        }

        public List<Calificacion> Calificaciones
        {
            get => calificaciones ??= new List<Calificacion>();
            set => calificaciones = value ?? new List<Calificacion>();
        }

        public Estudiante(string est, string id, string carr)
        {
             this.Id = id;
             this.Nombre = est;
             this.Carrera = carr; 
         }


        public double CalcularPromedio()
        { 
            if (Calificaciones == null || !Calificaciones.Any()) return 0.0;

            double numerador = Calificaciones.Sum(C => C.Nota * C.Materia.Creditos);
            double denomidar = Calificaciones.Sum(c => c.Materia.Creditos);

            if(denomidar > 0)
            {
                return numerador / denomidar;
            }
            else
            {
                return 0.0;
            }
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}, ID: {Id}, Carrera: {Carrera}, Promedio: {CalcularPromedio()} ");
        }

    }
}
