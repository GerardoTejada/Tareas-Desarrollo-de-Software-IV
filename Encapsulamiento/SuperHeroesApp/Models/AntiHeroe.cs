using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionDeAntiHeroe(string accion)
        {
            return $"El antiheroe {NombreEidenidadSecreta} ha realizado {accion}";
        }
    }
}
