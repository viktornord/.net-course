namespace Task5;

public class Content : DocumentPart
{
    public Content(string text) : base("Content", text)
    {
    }

    protected override ConsoleColor Color => ConsoleColor.Yellow;
}

