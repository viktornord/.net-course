namespace dot_net_course;

public static class Task2
{
    public static void Run()
    {
        Console.Write("Enter array size N: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Invalid size. N must be a positive integer.");
            return;
        }

        int[] array = new int[n];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(-100, 101);
        }

        Console.WriteLine($"Array ({n} elements): {string.Join(", ", array)}");
        Console.WriteLine($"Largest value: {array.Max()}");
        Console.WriteLine($"Smallest value: {array.Min()}");
        Console.WriteLine($"Sum of all elements: {array.Sum()}");
        Console.WriteLine($"Arithmetic mean: {(double)array.Sum() / n:F2}");

        int[] oddValues = array.Where(x => x % 2 != 0).ToArray();
        if (oddValues.Length == 0)
        {
            Console.WriteLine("Odd values: (none)");
        }
        else
        {
            Console.WriteLine($"Odd values: {string.Join(", ", oddValues)}");
        }
    }
}
