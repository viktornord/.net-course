namespace DotNetCourse;

/// <summary>
/// Task 3: Circle area using π and radius r (A = πR²).
/// </summary>
public static class Task3
{
    public static void Run()
    {
        const double Pi = Math.PI;
        double r = 5.0;

        double area = Pi * r * r;

        Console.WriteLine("π (pi) = {0}", Pi);
        Console.WriteLine("Radius r = {0}", r);
        Console.WriteLine("Area A = π × r² = {0:F4}", area);
    }
}
