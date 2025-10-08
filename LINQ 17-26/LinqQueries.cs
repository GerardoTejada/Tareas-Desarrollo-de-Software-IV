using System.Linq;
using System.Runtime.InteropServices;
public class LinqQueries

{
    private List<Book> librosCollection = new List<Book>();
    public LinqQueries()
    {
        using (StreamReader reader = new StreamReader("C:\\Users\\gerad\\OneDrive\\Escritorio\\LINQ\\books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true }) ?? Enumerable.Empty<Book>().ToList();

        }
    }

    public IEnumerable<Book> TodaLaColeccion()
    {
        return librosCollection;
    }

    public IEnumerable<Book> Fecha()
    {
        return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
    }

    public IEnumerable<Book> PaginaYTitulo()
    {
        //return librosCollection.Where(l => l.PageCount > 250 && l.Title.Contains("in Action"));
        return from libro in librosCollection where libro.PageCount > 250 && libro.Title.Contains("in Action") select libro;
    }

    public bool TodosLosLibrosTieneEstatus()
    {
        return librosCollection.All(p => p.Status != string.Empty);
    }

    public bool SiAlgunLibroPublicado2005()
    {
        return librosCollection.Any(p => p.PublishedDate.Year == 2005);
    }

    public IEnumerable<Book> contienePython()
    {
        return from libro in librosCollection where libro.Categories.Contains("Python") select libro;
    }

    public IEnumerable<Book> LibrosDeJavaAscendente()
    {
        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
    }

    public IEnumerable<Book> Libros450()
    {
        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
    }

    public IEnumerable<Book> Libros3Recientes()
    {
        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.PublishedDate.Year).TakeLast(3);
    }

    public IEnumerable<Book> LibrosConSkip()
    {
        return librosCollection.Where(p => p.PageCount > 400).Take(4).Skip(2);
    }

    public IEnumerable<libros> SeleccionLibros()
    {
        return librosCollection.Take(3)
            .Select(p => new libros { Title = p.Title, PageCount = p.PageCount });
    }
}

public class libros
{
    public required string Title { get; set; }
    public int PageCount { get; set; }
}