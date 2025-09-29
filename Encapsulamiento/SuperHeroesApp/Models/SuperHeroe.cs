using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHeroe : Heroe , ISuperHeroe// clase super poderes
    {
        private string _Nombre;
        public int Id { get; set; } = 1;
        public override string Nombre // encapsulamiento
        {
            get
            { 
                return _Nombre;
            }
            set
            {
                _Nombre = value.Trim();
            } 
        }

        public string NombreEidenidadSecreta // Encapsulamieno de lectura
        {
            get
            {
                return $"{Nombre} ({IdentidadSecreta})";
            }
        }
        public string IdentidadSecreta { get; set; }
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        // Metodo Constructors
        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public string usarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{NombreEidenidadSecreta} esta usando el super poder {item.Nombre}");
            }
            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{NombreEidenidadSecreta} ha salvado el mundo";
        }

        public override string SalvarLaTierra()
        {
            return $"{NombreEidenidadSecreta} ha salvado la tierra";
        }
    }
}
