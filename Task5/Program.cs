namespace Task5;

internal static class Program
{
    private static void Main()
    {
        Printer[] printers =
        [
            new RedPrinter(),
            new GreenPrinter(),
            new BluePrinter()
        ];

        foreach (var printer in printers)
        {
            printer.Print("Printed via polymorphism — each derived class uses its own color.");
        }
    }
}
