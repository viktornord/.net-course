namespace DotNetCourse;

/// <summary>
/// Task 4: Number of product delivery routes for N customers (N! permutations), factorial via do-while.
/// </summary>
public static class Task4
{
    public static void Run()
    {
        Console.Write("Enter the number of customers (N): ");
        int n = int.Parse(Console.ReadLine()!);

        if (n < 0)
        {
            Console.WriteLine("N must be zero or positive.");
            return;
        }

        long routes = FactorialDoWhile(n);

        Console.WriteLine("Number of possible delivery routes for {0} customer(s): {1}", n, routes);
        Console.WriteLine("(N! = {0}! = {1})", n, routes);
    }

    static long FactorialDoWhile(int n)
    {
        if (n <= 1)
        {
            return 1;
        }

        long result = 1;
        int i = 2;

        do
        {
            result *= i;
            i++;
        } while (i <= n);

        return result;
    }
}
