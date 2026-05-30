namespace DotNetCourse;

/// <summary>
/// Task 2: Sum of numbers between A and B, and all odd values in that range (A &lt; B).
/// </summary>
public static class Task2
{
    public static void Run()
    {
        Console.Write("Enter A: ");
        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Enter B (must be greater than A): ");
        int b = int.Parse(Console.ReadLine()!);

        if (a >= b)
        {
            Console.WriteLine("Invalid input: A must be less than B.");
            return;
        }

        int sum = 0;
        var oddValues = new List<int>();

        for (int i = a + 1; i < b; i++)
        {
            sum += i;
            if (i % 2 != 0)
            {
                oddValues.Add(i);
            }
        }

        Console.WriteLine("Sum of numbers between {0} and {1}: {2}", a, b, sum);

        if (oddValues.Count == 0)
        {
            Console.WriteLine("Odd values between {0} and {1}: (none)", a, b);
        }
        else
        {
            Console.WriteLine("Odd values between {0} and {1}: {2}", a, b, string.Join(", ", oddValues));
        }
    }
}
