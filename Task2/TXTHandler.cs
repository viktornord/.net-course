namespace Task2;

internal sealed class TXTHandler : AbstractHandler
{
    public override void Open()
    {
        Console.WriteLine("Opening TXT document...");
    }

    public override void Create()
    {
        Console.WriteLine("Creating TXT document...");
    }

    public override void Change()
    {
        Console.WriteLine("Editing TXT document...");
    }

    public override void Save()
    {
        Console.WriteLine("Saving TXT document...");
    }
}
