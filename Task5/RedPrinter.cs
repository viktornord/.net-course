namespace Task5;

public class RedPrinter : Printer
{
    public override void Print(string value)
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(value);
        Console.ForegroundColor = previousColor;
    }
}
