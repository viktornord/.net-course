namespace Task2;

internal static class Program
{
    private static void Main()
    {
        Console.Write("Enter document format (xml/txt/doc): ");
        var format = Console.ReadLine();

        AbstractHandler? handler = format?.Trim().ToLowerInvariant() switch
        {
            "xml" => new XMLHandler(),
            "txt" => new TXTHandler(),
            "doc" => new DOCHandler(),
            _ => null
        };

        if (handler is null)
        {
            Console.WriteLine("Unsupported format. Please choose xml, txt, or doc.");
            return;
        }

        handler.Open();
        handler.Create();
        handler.Change();
        handler.Save();
    }
}
