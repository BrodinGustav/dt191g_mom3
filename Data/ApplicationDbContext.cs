using Microsoft.EntityFrameworkCore;
namespace dt191g_mom3.Data;

//Anslutning
public class ApplicationDbContext : DbContext { //Ärver från klassen DbContect

    //Konstruktur
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //Skickar med inställningar, tar ApplicationDbContext och lagrar i variabeln options som skickas upp till basklassen 
    {

    }

    //Tabeller
    public DbSet<Book> Books { get; set; }

    public DbSet<Author> Authors { get; set; }


}