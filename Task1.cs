namespace DotNetCourse;

/// <summary>
/// Task 1: Evaluate compound assignments with ++ and -- on x=10, y=12, z=3.
/// </summary>
public static class Task1
{
    public static void Run()
    {
        int x = 10, y = 12, z = 3;

        Console.WriteLine("Initial: x = {0}, y = {1}, z = {2}", x, y, z);
        Console.WriteLine();

        Console.WriteLine("1) x += y - x++ * z;");
        x += y - x++ * z;
        Console.WriteLine("   After: x = {0}, y = {1}, z = {2}", x, y, z);
        Console.WriteLine();

        Console.WriteLine("2) z = --x - y * 5;");
        z = --x - y * 5;
        Console.WriteLine("   After: x = {0}, y = {1}, z = {2}", x, y, z);
        Console.WriteLine();

        Console.WriteLine("3) y /= x + 5 % z;");
        y /= x + 5 % z;
        Console.WriteLine("   After: x = {0}, y = {1}, z = {2}", x, y, z);
        Console.WriteLine();

        Console.WriteLine("4) z = x++ + y * 5;");
        z = x++ + y * 5;
        Console.WriteLine("   After: x = {0}, y = {1}, z = {2}", x, y, z);
        Console.WriteLine();

        Console.WriteLine("5) x = y - x++ * z;");
        x = y - x++ * z;
        Console.WriteLine("   After: x = {0}, y = {1}, z = {2}", x, y, z);
        Console.WriteLine();

        Console.WriteLine("Final: x = {0}, y = {1}, z = {2}", x, y, z);
        Console.WriteLine();
    }
}
