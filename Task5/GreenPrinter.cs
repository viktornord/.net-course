namespace Task5;

public class GreenPrinter : Printer
{
    public override void Print(string value)
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(value);
        Console.ForegroundColor = previousColor;
    }
}
