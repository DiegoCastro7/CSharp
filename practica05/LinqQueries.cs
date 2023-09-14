using System.Linq;
public class LinqQueries{
    List<Book> lstBooks = new List<Book>();
    public LinqQueries(){
        using (StreamReader reader = new StreamReader("books.json")){
            string json = reader.ReadToEnd();
            this.lstBooks = System.Text.Json.JsonSerializer
            .Deserialize<List<Book>>(json,new System.Text.Json.JsonSerializerOptions()
            {PropertyNameCaseInsensitive = true}) ?? new List<Book>();
        }
    }
    public IEnumerable<Book> AllCollection(){
        return lstBooks;
    }
    public IEnumerable<Book> BookAfter2000(){
        return from book in lstBooks where book.PublishedDate.Year >2000 select book;
    }
    public IEnumerable<Book> AboutAndroid(){
        return from book in lstBooks where (book.Title.Contains("Android")) select book;
    }
    public IEnumerable<Book> AboutAndroidAfter2010(){
        return from book in lstBooks where (book.Title.Contains("Android"))&&(book.PublishedDate.Year >2010) select book;
    }
    public IEnumerable<Book> AboutAction250pg(){
        return from book in lstBooks where (book.Title.Contains("Action"))&&(book.PageCount > 250) select book;
    }
    public bool Validarstatus(){
        Console.ForegroundColor = ConsoleColor.Yellow;
        return lstBooks.All(book => book.Status.Length > 0);
    }
    public IEnumerable<Book> BookIn2005(){
        return from book in lstBooks where book.PublishedDate.Year ==2005 select book;
    }
    public bool Validarfecha2005(){
        Console.ForegroundColor = ConsoleColor.Yellow;
        if (lstBooks.Any(book => book.PublishedDate.Year == 2005)){
            Program.ImprimirValores(BookIn2005());
        }
        return lstBooks.Any(book => book.PublishedDate.Year == 2005);
    }
}
