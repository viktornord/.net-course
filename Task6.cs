namespace DotNetCourse;

/// <summary>
/// Task 6: Check whether a number is a power of two (exactly one bit set).
/// </summary>
public static class Task6
{
    public static void Run()
    {
        Console.Write("Enter an integer: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Number: {0}", number);
        Console.WriteLine();

        bool byBitwise = number > 0 && (number & (number - 1)) == 0;
        Console.WriteLine("Option 1 — bitwise (n > 0 and n & (n - 1) == 0):");
        Console.WriteLine("  {0} is{1}a power of two.", number, byBitwise ? " " : " not ");

        bool byLoop = IsPowerOfTwoByDivision(number);
        Console.WriteLine();
        Console.WriteLine("Option 2 — repeated division by 2:");
        Console.WriteLine("  {0} is{1}a power of two.", number, byLoop ? " " : " not ");
    }

    private static bool IsPowerOfTwoByDivision(int n)
    {
        if (n <= 0)
            return false;

        while (n % 2 == 0)
            n /= 2;

        return n == 1;
    }
}
