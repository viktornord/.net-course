namespace dot_net_course;

public class Author
{
    string name;

    public Author(string name)
    {
        this.name = name;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(name);
        Console.ResetColor();
    }
}
