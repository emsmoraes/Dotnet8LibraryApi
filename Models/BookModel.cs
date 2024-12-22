namespace Dotnet8LibraryApi.Models;
public class BookModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public AuthorModel Author { get; set; }
}