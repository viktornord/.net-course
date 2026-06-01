namespace Task4;

public class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("The document is saved in a new format");
    }
}
