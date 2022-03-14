using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
  public class LibraryContext : DbContext
  {
    public DbSet<Customer> Customer {get;set;}
    public DbSet<Book> Book { get; set; }
    public DbSet<CategoryItem> CategoryItem {get;set;}

    public LibraryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}