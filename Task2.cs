namespace DotNetCourse;

/// <summary>
/// Task 2: Arithmetic mean of three integers.
/// </summary>
public static class Task2
{
    public static void Run()
    {
        int a = 10, b = 20, c = 30;

        Console.WriteLine("Values: a = {0}, b = {1}, c = {2}", a, b, c);
        Console.WriteLine();

        int intMean = (a + b + c) / 3;
        Console.WriteLine("Mean using int division (a + b + c) / 3 = {0}", intMean);
        Console.WriteLine("Problem: integer division truncates the fractional part.");

        double correctMean = (a + b + c) / 3.0;
        Console.WriteLine("\nMean using double (a + b + c) / 3.0 = {0}", correctMean);
        Console.WriteLine("\nBetter type for the result: double (or decimal if you need exact decimal arithmetic).");
    }
}
