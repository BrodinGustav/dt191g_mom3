using Microsoft.EntityFrameworkCore;
namespace dt191g_mom3.Data;

//Anslutning
public class ApplicationDbContext : DbContext //Ärver från basklassen DbContect
{ 

    //Konstruktur

    // Tar emot DbContextOptions som används för att konfigurera och ansluta till databasen.
    // Dessa alternativ vidarebefordras till basklassen (DbContext) för att hantera databasanslutningen.
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
    {

    }

    //Tabeller
    public DbSet<Book> Books { get; set; }

    public DbSet<Author> Authors { get; set; }


}