namespace DotNetCourse;

/// <summary>
/// Task 3: Determine which numeric interval [0–14], [15–35], [36–50], or [51–100] contains the user's number.
/// </summary>
public static class Task3
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Invalid number entered.");
            return;
        }

        if (number < 0 || number > 100)
        {
            Console.WriteLine("The number is not included in any of the available numerical intervals (0–100).");
            return;
        }

        switch (number)
        {
            case >= 0 and <= 14:
                Console.WriteLine("The number {0} falls in the interval [0 - 14].", number);
                break;
            case >= 15 and <= 35:
                Console.WriteLine("The number {0} falls in the interval [15 - 35].", number);
                break;
            case >= 36 and <= 50:
                Console.WriteLine("The number {0} falls in the interval [36 - 50].", number);
                break;
            case >= 51 and <= 100:
                Console.WriteLine("The number {0} falls in the interval [51 - 100].", number);
                break;
            default:
                Console.WriteLine("The number is not included in any of the available numerical intervals.");
                break;
        }
    }
}
