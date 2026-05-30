namespace DotNetCourse;

/// <summary>
/// Task 4: Employee bonus by years of service.
/// </summary>
public static class Task4
{
    public static void Run()
    {
        Console.Write("Enter monthly salary: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal salary) || salary < 0)
        {
            Console.WriteLine("Invalid salary.");
            return;
        }

        Console.Write("Enter years of service: ");
        if (!int.TryParse(Console.ReadLine(), out int years) || years < 0)
        {
            Console.WriteLine("Invalid years of service.");
            return;
        }

        decimal rate = years switch
        {
            < 5 => 0.10m,
            < 10 => 0.15m,
            < 15 => 0.25m,
            < 20 => 0.35m,
            < 25 => 0.45m,
            _ => 0.50m
        };

        decimal bonus = salary * rate;

        Console.WriteLine();
        Console.WriteLine("Years of service: {0}", years);
        Console.WriteLine("Bonus rate:       {0:P0}", rate);
        Console.WriteLine("Salary:           {0:C2}", salary);
        Console.WriteLine("Bonus:            {0:C2}", bonus);
        Console.WriteLine("Total:            {0:C2}", salary + bonus);
    }
}
