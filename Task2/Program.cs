namespace Task2;

internal static class Program
{
    private static void Main()
    {
        Console.Write("Enter array size N: ");
        if (!int.TryParse(Console.ReadLine(), out var n) || n <= 0)
        {
            Console.WriteLine("Invalid value. N must be a positive integer.");
            return;
        }

        var numbers = new int[n];
        var random = new Random();

        for (var i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-100, 101);
        }

        Console.WriteLine($"Array: {string.Join(", ", numbers)}");

        var max = numbers.Max();
        var min = numbers.Min();
        var sum = numbers.Sum();
        var average = numbers.Average();
        var oddNumbers = numbers.Where(number => number % 2 != 0);

        Console.WriteLine($"Largest element: {max}");
        Console.WriteLine($"Smallest element: {min}");
        Console.WriteLine($"Sum of all elements: {sum}");
        Console.WriteLine($"Arithmetic mean: {average:F2}");
        Console.WriteLine($"Odd elements: {string.Join(", ", oddNumbers)}");
   
    }
}
