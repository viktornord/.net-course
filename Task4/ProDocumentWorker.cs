namespace Task4;

public class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Document edited");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Saving a document in the old format, saving in other formats is available in the Expert version");
    }
}
