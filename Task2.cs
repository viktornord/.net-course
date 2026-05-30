namespace DotNetCourse.Tasks;

/// <summary>
/// Task 2: Store π and e without losing the precision of the given literals.
/// </summary>
public static class Task2
{
    public static void Run()
    {
        // decimal preserves base-10 literals exactly (unlike float/double for some fractions).
        decimal pi = 3.141592653m;
        decimal e = 2.7182818284590452m;

        Console.WriteLine("Pi and Euler's number (decimal literals, full precision):");
        Console.WriteLine($"pi = {pi}");
        Console.WriteLine($"e  = {e}");
    }
}
