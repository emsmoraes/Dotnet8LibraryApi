using Dotnet8LibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet8LibraryApi.Data;
public class AppDbContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<AuthorModel> Authors { get; set; }
    public DbSet<BookModel> Books { get; set; }
}