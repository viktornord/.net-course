namespace DotNetCourse;

/// <summary>
/// Task 7: De Morgan's theorem — A | B is equivalent to ~(~A &amp; ~B).
/// </summary>
public static class Task7
{
    public static void Run()
    {
        Console.WriteLine("De Morgan's theorem:  A | B  ≡  ~(~A & ~B)");
        Console.WriteLine();
        Console.WriteLine("Original:     result = A | B");
        Console.WriteLine("Equivalent:   result = ~(~A & ~B)");
        Console.WriteLine();

        Console.Write("Enter A (0 or 1): ");
        if (!int.TryParse(Console.ReadLine(), out int a) || a is not (0 or 1))
        {
            Console.WriteLine("Invalid input. Use 0 or 1.");
            return;
        }

        Console.Write("Enter B (0 or 1): ");
        if (!int.TryParse(Console.ReadLine(), out int b) || b is not (0 or 1))
        {
            Console.WriteLine("Invalid input. Use 0 or 1.");
            return;
        }

        int original = a | b;
        int equivalent = ~(~a & ~b);

        Console.WriteLine();
        Console.WriteLine("A = {0}, B = {1}", a, b);
        Console.WriteLine("A | B           = {0}", original);
        Console.WriteLine("~(~A & ~B)      = {0}", equivalent);
        Console.WriteLine("Expressions match: {0}", original == equivalent);
    }
}
