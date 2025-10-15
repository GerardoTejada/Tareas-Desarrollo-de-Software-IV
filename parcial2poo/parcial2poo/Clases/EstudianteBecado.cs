using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2poo.Clases
{
    internal class EstudianteBecado : Estudiante
    {
        private double porcentaje;

        public double PorcentajeBeca {
            get 
            { 
                return porcentaje;
            } 
            set 
            { 
                if(0 <= value && value <= 100)
                {
                    porcentaje = value;
                }
            } 
        }

        public double CalcularMatriculaConDescuento(double matriculaBase)
        {
            return matriculaBase * (1 - (PorcentajeBeca / 100.0));
        }

        public override void getValues(double matriculaBase)
        {
            Console.WriteLine($"Porcentaje de beca {PorcentajeBeca}, Matricula con descuento calculada: {CalcularMatriculaConDescuento(matriculaBase)} ");
        }
    }
}
