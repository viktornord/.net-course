namespace DotNetCourse.Tasks;

/// <summary>
/// Task 3: String variables with escape sequences and observed output.
/// </summary>
public static class Task3
{
    public static void Run()
    {
        string line1 = "\nmy line 1";
        string line2 = "\tmy line 2";
        string line3 = "\amy line 3";

        Console.WriteLine("--- line1 (\\n = new line) ---");
        Console.Write(line1);
        Console.WriteLine("\n[end of line1 output]");

        Console.WriteLine("--- line2 (\\t = horizontal tab) ---");
        Console.Write(line2);
        Console.WriteLine("\n[end of line2 output]");

        Console.WriteLine("--- line3 (\\a = alert / bell) ---");
        Console.Write(line3);
        Console.WriteLine("\n[end of line3 output]");

        Console.WriteLine("\nConclusions:");
        Console.WriteLine("- \\n starts output on a new line; text may appear below the label.");
        Console.WriteLine("- \\t inserts a tab; columns align differently from spaces.");
        Console.WriteLine("- \\a is the alert character (often a beep); 'm' is normal text after \\a.");
        Console.WriteLine("- Without escape sequences, backslash sequences are interpreted at compile time.");
    }
}
