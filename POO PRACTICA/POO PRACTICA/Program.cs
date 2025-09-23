// See https://aka.ms/new-console-template for more information
using POO_PRACTICA.Clases;

namespace POO_PRACTICA
{
    class POO_PRACTICA
    {
        static void Main(string[] args)
        {
            // Lista de objeto de Miguel
            List<Objeto> ObjsDeMiguel = new List<Objeto>();
            ObjsDeMiguel.Add(new Objeto(1,"Computadora"));
            ObjsDeMiguel.Add(new Objeto(2, "Disco SDD"));
            ObjsDeMiguel.Add(new Objeto(3, "Cuaderno"));
            // Declaracion de Miguel
            var Miguel = new Persona("Miguel", 20, genero.hombre,ObjsDeMiguel);

            // Persona Miguel
            Miguel.caminarAct();
            Miguel.verObjs();
            Miguel.verDescripcion();
        }
    }


}