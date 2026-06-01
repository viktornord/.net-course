namespace Task5;

public class BluePrinter : Printer
{
    public override void Print(string value)
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(value);
        Console.ForegroundColor = previousColor;
    }
}
