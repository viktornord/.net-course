namespace DotNetCourse;

/// <summary>
/// Task 3: Currency conversion from amount and exchange rate.
/// </summary>
public static class Task3
{
    public static void Run()
    {
        Console.Write("Enter amount in source currency: ");
        decimal amount = decimal.Parse(Console.ReadLine()!);

        Console.Write("Enter conversion rate to target currency: ");
        decimal rate = decimal.Parse(Console.ReadLine()!);

        decimal converted = amount * rate;

        Console.WriteLine();
        Console.WriteLine("Amount:        {0}", amount);
        Console.WriteLine("Rate:          {0}", rate);
        Console.WriteLine("Converted amount: {0}", converted);
    }
}
