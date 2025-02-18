using Microsoft.AspNetCore.SignalR;

namespace dt191g_mom3;

public class Book {
    //Properties
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Published   { get; set; }

    //En bok kan ha en författare
    public int? AuthorId { get; set; }
    public Author? Author { get; set; } //Knyter ihop med Author-modell
}