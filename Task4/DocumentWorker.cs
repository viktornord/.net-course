namespace Task4;

public class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Document is open");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Editing a document is available in the Pro version");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Saving a document is available in the Pro version");
    }
}
