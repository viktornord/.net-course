namespace Task4;

internal static class Program
{
    private static void Main()
    {
        Console.Write("Enter access key (pro, exp, or leave empty for free): ");
        var key = Console.ReadLine()?.Trim().ToLowerInvariant();

        DocumentWorker worker = key switch
        {
            "pro" => new ProDocumentWorker(),
            "exp" => new ExpertDocumentWorker(),
            _ => new DocumentWorker()
        };

        worker.OpenDocument();
        worker.EditDocument();
        worker.SaveDocument();
    }
}
