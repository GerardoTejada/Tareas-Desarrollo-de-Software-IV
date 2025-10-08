// See https://aka.ms/new-console-template for more information


void Imprimirlista(IEnumerable<libros> lista)
{
    Console.WriteLine("{0,-70} {1,7}", "Titulo", "N. paginas");
    foreach (var item in lista)
        Console.WriteLine("{0,-70} {1,7}", item.Title, item.PageCount);
}
try
{

}
catch (Exception e)
{
    System.Console.WriteLine(e.Message);
}
LinqQueries queries = new LinqQueries();
Console.WriteLine("==================================================================================================");

// Toda la coleccion
//Imprimirlista(queries.TodaLaColeccion());


// Imprirmir poe pagina 250 y titulo in action
//Imprimirlista(queries.PaginaYTitulo());

// Todos los libros tiene estatus
//System.Console.WriteLine("Todos los libros tienen estatus?: "+queries.TodosLosLibrosTieneEstatus());

// Si algun libro fue publicado en 2005 
//System.Console.WriteLine($"Algun libro fue publicado en el 2005: " + queries.SiAlgunLibroPublicado2005());

// Contiene Python
//Imprimirlista(queries.contienePython());

//Libros de java por nombre ascemdemte
//Imprimirlista(queries.LibrosDeJavaAscendente());

//Libros quie tengan mas de 450 paginas ordenadas por numero de paginas en formas descendente
//Imprimirlista(queries.Libros450());

//Libros quie tengan mas de 450 paginas ordenadas por numero de paginas en formas descendente
//Imprimirlista(queries.Libros3Recientes());

//Libros mas de 400 paginas seleccionando cuarto y tercer libro
//Imprimirlista(queries.LibrosConSkip());

//Libros mas de 400 paginas seleccionando cuarto y tercer libro
//Imprimirlista(queries.SeleccionLibros());

// Cantidad de libros segun su cantidad de paginas 200 a 500
Console.WriteLine($"Cantidad de libros entre 200 y 500 paginas con count: {queries.contarLibros()}");

//Long count Cantidad de libros segun su cantidad de paginas 200 a 500
Console.WriteLine($"Cantidad de libros entre 200 y 500 paginas con long count: {queries.contarLibrosLongCount()}");

//Minimo de fechas de fechas de publicacion 
Console.WriteLine($"Minimo de fechas de publicacion: {queries.minimoDeFechas()}");

//Maximo de paginas de una coleccion de libros
Console.WriteLine($"Maximo de paginas de una coleccion de libros: {queries.maximoDePaginas()}");

//
Console.WriteLine($"Maximo de paginas de una coleccion de libros: {queries.maximoDePaginas()}");
