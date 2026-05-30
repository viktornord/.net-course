namespace dot_net_course;

public static class Task6
{
    public static void Run()
    {
        Console.WriteLine("Task 6 — Calculate (integer division by 5)");
        Console.WriteLine();

        Console.Write("First value: ");
        int a = ReadInt();

        Console.Write("Second value: ");
        int b = ReadInt();

        Console.Write("Third value: ");
        int c = ReadInt();

        var (q1, q2, q3) = Calculate(a, b, c);

        Console.WriteLine();
        Console.WriteLine($"Results (each argument ÷ 5): {q1.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {q2.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {q3.ToString(System.Globalization.CultureInfo.InvariantCulture)}");
   
    }

    public static (decimal first, decimal second, decimal third) Calculate(int first, int second, int third)
    {
        return (first / (decimal)5, second / (decimal)5, third / (decimal)5);
    }

    private static int ReadInt()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                return value;
            }

            Console.Write("Enter a valid integer: ");
        }
    }
}
