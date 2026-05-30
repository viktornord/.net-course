namespace DotNetCourse;

/// <summary>
/// Task 6: Draw a rectangle of stars using nested loops and height/width variables.
/// </summary>
public static class Task6
{
    public static void Run()
    {
        int height = 5;
        int width = 8;

        Console.WriteLine("Rectangle of stars ({0} rows × {1} columns):", height, width);
        Console.WriteLine();

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
