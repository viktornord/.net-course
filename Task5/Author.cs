namespace Task5;

public class Author : DocumentPart
{
    public Author(string text) : base("Author", text)
    {
    }

    protected override ConsoleColor Color => ConsoleColor.Green;
}

