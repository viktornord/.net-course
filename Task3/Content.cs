namespace dot_net_course;

public class Content
{
    string text;

    public Content(string text)
    {
        this.text = text;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(text);
        Console.ResetColor();
    }
}
