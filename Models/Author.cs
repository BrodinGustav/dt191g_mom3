namespace dt191g_mom3;

public class Author{

    //Properties
    public int Id { get; set; }

    public string? Name { get; set; }

    //En författare kan ha flera böcker
    public List<Book>? Books { get; set; }


}

