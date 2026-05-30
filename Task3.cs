namespace DotNetCourse;

/// <summary>
/// Task 3: Evaluate compound bitwise and arithmetic expressions (x = 5, y = 10, z = 15).
/// </summary>
public static class Task3
{
    public static void Run()
    {
        int x = 5, y = 10, z = 15;

        Console.WriteLine("Initial values: x = {0}, y = {1}, z = {2}", x, y, z);
        Console.WriteLine();

        Console.WriteLine("1) x += y >> x++ * z;");
        Console.WriteLine("   Right side: y >> (x++ * z) — postfix ++ uses 5, then x becomes 6; 5 * 15 = 75; 10 >> 75 = 0.");
        Console.WriteLine("   x = 5 + 0 = 5 (assignment overwrites the increment from x++).");
        Console.WriteLine("   → x = {0}, y = {1}, z = {2}", x, y, z);
        Console.WriteLine();

        Console.WriteLine("2) z = ++x & y * 5;");
        Console.WriteLine("   ++x → 6; y * 5 = 50; 6 & 50 = 2.");
        z = ++x & y * 5;
        Console.WriteLine("   → x = {0}, y = {1}, z = {2}", x, y, z);
        Console.WriteLine();

        Console.WriteLine("3) y /= x + 5 | z;");
        Console.WriteLine("   (x + 5) | z = 11 | 2 = 11; y = 10 / 11 = 0.");
        y /= x + 5 | z;
        Console.WriteLine("   → x = {0}, y = {1}, z = {2}", x, y, z);
        Console.WriteLine();

        Console.WriteLine("4) z = x++ & y * 5;");
        Console.WriteLine("   x++ uses 6; y * 5 = 0; 6 & 0 = 0.");
        z = x++ & y * 5;
        Console.WriteLine("   → x = {0}, y = {1}, z = {2}", x, y, z);
        Console.WriteLine();

        Console.WriteLine("5) x = y << x++ ^ z;");
        Console.WriteLine("   (y << x++) ^ z — x++ uses 7; 0 << 7 = 0; 0 ^ 0 = 0.");
        x = y << x++ ^ z;
        Console.WriteLine("   → x = {0}, y = {1}, z = {2}", x, y, z);
        Console.WriteLine();

        Console.WriteLine("Final: x = {0}, y = {1}, z = {2}", x, y, z);
    }
}
