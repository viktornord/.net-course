namespace Task2;

internal sealed class DOCHandler : AbstractHandler
{
    public override void Open()
    {
        Console.WriteLine("Opening DOC document...");
    }

    public override void Create()
    {
        Console.WriteLine("Creating DOC document...");
    }

    public override void Change()
    {
        Console.WriteLine("Editing DOC document...");
    }

    public override void Save()
    {
        Console.WriteLine("Saving DOC document...");
    }
}
