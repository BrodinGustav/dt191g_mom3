using Microsoft.EntityFrameworkCore;
namespace dt191g_mom3.Data;

//Anslutning
public class ApplicationDbContext : DbContext {

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
    {

    }

    //Tabeller
    public DbSet<Book> Books { get; set; }

    public DbSet<Author> Authors { get; set; }


}