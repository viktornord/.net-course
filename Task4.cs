namespace DotNetCourse;

/// <summary>
/// Task 4: Cylinder volume V = πR²h and surface area S = 2πR(R + h).
/// </summary>
public static class Task4
{
    public static void Run()
    {
        const double Pi = Math.PI;
        double r = 3.0;
        double h = 10.0;

        double volume = Pi * r * r * h;
        double surfaceArea = 2 * Pi * r * (r + h);

        Console.WriteLine("Radius R = {0}, height h = {1}", r, h);
        Console.WriteLine("Volume V = πR²h = {0:F4}", volume);
        Console.WriteLine("Surface area S = 2πR(R + h) = {0:F4}", surfaceArea);
    }
}
