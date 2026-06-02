namespace Task5;

public abstract class DocumentPart
{
    private readonly string _name;
    private readonly string _text;

    protected DocumentPart(string name, string text)
    {
        _name = name;
        _text = text;
    }

    protected abstract ConsoleColor Color { get; }

    public void Show()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"{_name}: {_text}");
        Console.ResetColor();
    }
}

