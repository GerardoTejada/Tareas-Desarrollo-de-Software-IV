using parcial2poo.Clases;
using System.Net.Http.Headers;

namespace principal
{
    class main
    {
        static void Main(string[] args)
        {
            Materia m1 = new Materia("Programación", "INF101", 3, 30, 25);
            Materia m2 = new Materia("Matemáticas", "MAT201", 4, 40, 35);
            Materia m3 = new Materia("Bases de Datos", "INF202", 3, 25, 20);

            Estudiante e1 = new Estudiante("Ana Torres", "E001", "Ingeniería");
            Estudiante e2 = new Estudiante("Luis Gómez", "E002", "Informática");

            EstudianteBecado eb1 = new EstudianteBecado("María López", "E003", "Sistemas");

            Calificacion c1 = new Calificacion(e1, m1, 85);
            Calificacion c2 = new Calificacion(e2, m2, 92);
            Calificacion c3 = new Calificacion(eb1, m3, 78);

  
            e1.Calificaciones.Add(c1);
            e2.Calificaciones.Add(c2);
            eb1.Calificaciones.Add(c3);

            List<IMostrable> items = new List<IMostrable>
            {
                m1, m2,m3, e1,e2,eb1,c1,c2,c3
            };
            
            foreach(var i in items)
            {
                i.MostrarDatos();
            }
            Console.WriteLine($"Promedio de Ana Torres: {e1.CalcularPromedio()}");
            Console.WriteLine($"Carga semanal de la materia de Programacion: {m1.CalcularCargarSemanal(3)}");
            Console.WriteLine($"Calificacion por la estudiante {c1.Estudiante.Nombre} {c1.CalcularPuntos()}");
            Console.WriteLine($"Matricula calculada del estudiante becado {eb1.Nombre} : {eb1.CalcularMatriculaConDescuento(100)}");
        }
    }
}