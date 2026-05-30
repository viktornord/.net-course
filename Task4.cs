namespace DotNetCourse;

/// <summary>
/// Task 4: Sign, primality (divisor traversal), and divisibility by 2, 5, 3, 6, 9.
/// </summary>
public static class Task4
{
    public static void Run()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine()!);

        AnalyzeNumber(n);
    }

    static void AnalyzeNumber(int n)
    {
        Console.WriteLine();
        Console.WriteLine("Number: {0}", n);
        Console.WriteLine("Sign: {0}", n > 0 ? "positive" : n < 0 ? "negative" : "zero");
        Console.WriteLine("Prime: {0}", IsPrime(n) ? "yes" : "no");
        Console.WriteLine("Divisible by 2 without remainder: {0}", IsDivisible(n, 2));
        Console.WriteLine("Divisible by 5 without remainder: {0}", IsDivisible(n, 5));
        Console.WriteLine("Divisible by 3 without remainder: {0}", IsDivisible(n, 3));
        Console.WriteLine("Divisible by 6 without remainder: {0}", IsDivisible(n, 6));
        Console.WriteLine("Divisible by 9 without remainder: {0}", IsDivisible(n, 9));
    }

    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        int abs = Math.Abs(n);
        int divisorCount = 0;

        // Divisors pair as (d, n/d). For d > n/2 and d < n, n/d < 2, so no divisor exists there except n itself.
        for (int d = 1; d <= abs / 2; d++)
        {
            if (abs % d == 0)
            {
                divisorCount++;
            }
        }

        divisorCount++; // n is always divisible by itself

        return divisorCount == 2;
    }

    static bool IsDivisible(int n, int divisor)
    {
        return divisor != 0 && n % divisor == 0;
    }
}
