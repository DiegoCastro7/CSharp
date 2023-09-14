using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        int?[] arg2 = new int?[5];
        Console.WriteLine(arg2[0]);
        LinqQueries queries = new LinqQueries();
        Console.WriteLine("Coleccion de libros - Todos los libros");
        ImprimirValores(queries.AllCollection());
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Coleccion de libros - Libros despues del 2000");
        ImprimirValores(queries.BookAfter2000());
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Coleccion de libros - Acerca de Android");
        ImprimirValores(queries.AboutAndroid());
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Coleccion de libros - Acerca de Android despues de 2010");
        ImprimirValores(queries.AboutAndroidAfter2010());
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Coleccion de libros - Acerca de Action con mas de 250 paginas");
        ImprimirValores(queries.AboutAction250pg());
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Coleccion de libros - Status de los libros");
        Console.WriteLine(queries.Validarstatus() ? "Todos los libros tienen estatus" : "Al menos uno de los libros no tiene status");
        Console.ResetColor();
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Coleccion de libros - Libros publicados en 2005");
        Console.WriteLine(queries.Validarfecha2005() ? "Al menos uno de los libros fue publicado en 2005" : "Ninguno de los libros fue publicado en 2005");
        Console.ResetColor();
        Console.ReadKey();
        Console.Clear();
    }
    public static void ImprimirValores(IEnumerable<Book> books){
        int registros = 0;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("{0,-70} {1,7} {2,20}", "Titulo", "N.Paginas", "Fecha publicacion");
        foreach (Book book in books){
            Console.ForegroundColor = ConsoleColor.Yellow;
            registros++;
            Console.WriteLine("{0,-70} {1,7} {2,20}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
        }
        Console.ResetColor();
    }
}