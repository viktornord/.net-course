namespace dot_net_course;

public class Title
{
    string text;

    public Title(string text)
    {
        this.text = text;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(text);
        Console.ResetColor();
    }
}
