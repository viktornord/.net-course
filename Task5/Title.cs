namespace Task5;

public class Title : DocumentPart
{
    public Title(string text) : base("Title", text)
    {
    }

    protected override ConsoleColor Color => ConsoleColor.Cyan;
}

