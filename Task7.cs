namespace DotNetCourse;

/// <summary>
/// Task 7: All arithmetic operations on two integer variables.
/// </summary>
public static class Task7
{
    public static void Run()
    {
        int a = 17, b = 5;

        Console.WriteLine("a = {0}, b = {1}", a, b);
        Console.WriteLine();
        Console.WriteLine("a + b = {0}", a + b);
        Console.WriteLine("a - b = {0}", a - b);
        Console.WriteLine("a * b = {0}", a * b);
        Console.WriteLine("a / b = {0}  (integer division)", a / b);
        Console.WriteLine("a % b = {0}", a % b);
    }
}
