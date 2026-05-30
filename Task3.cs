namespace dot_net_course;

/// <summary>
/// Number of delivery routes to N customers with one vehicle = N! (permutations).
/// </summary>
public static class Task3
{
    public static void Run()
    {
        Console.WriteLine("Task 3 — Product delivery routes");
        Console.WriteLine("One machine visits each of N customers exactly once.");
        Console.WriteLine();

        Console.Write("Number of customers (N): ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int n) || n < 0)
        {
            Console.WriteLine("Enter a non-negative integer.");
            return;
        }

        long routes = FactorialRecursive(n);
        Console.WriteLine();
        Console.WriteLine($"Possible delivery routes: {routes} (= {n}!)");
        Console.WriteLine();
        PrintRecursionExplanation();
    }

    /// <summary>
    /// Factorial N! computed with recursion (as required by the assignment).
    /// </summary>
    public static long FactorialRecursive(int n)
    {
        if (n <= 1)
        {
            return 1;
        }

        return n * FactorialRecursive(n - 1);
    }

    private static void PrintRecursionExplanation()
    {
        Console.WriteLine("Why recursion is not recommended for factorial:");
        Console.WriteLine("  • Each recursive call uses stack space — for large N you risk StackOverflowException.");
        Console.WriteLine("  • Function-call overhead makes an iterative loop faster for the same result.");
        Console.WriteLine("  • long overflows quickly (e.g. 21! does not fit in Int64); recursion does not fix that.");
        Console.WriteLine("  • An iterative multiply loop is simpler to read, test, and maintain in production code.");
    }
}
