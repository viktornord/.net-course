namespace DotNetCourse;

/// <summary>
/// Task 6: Arithmetic mean of three integers via Calculate.
/// </summary>
public static class Task6
{
    public static void Run()
    {
        Console.Write("Enter first integer: ");
        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Enter second integer: ");
        int b = int.Parse(Console.ReadLine()!);

        Console.Write("Enter third integer: ");
        int c = int.Parse(Console.ReadLine()!);

        Calculate(a, b, c);
    }

    static void Calculate(int a, int b, int c)
    {
        double mean = (a + b + c) / 3.0;
        Console.WriteLine("Arithmetic mean of {0}, {1}, and {2}: {3}", a, b, c, mean);
    }
}
