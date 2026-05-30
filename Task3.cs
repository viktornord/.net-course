namespace DotNetCourse;

/// <summary>
/// Task 3: Draw a rectangle, right triangle, equilateral triangle, and rhombus using Console.Write.
/// </summary>
public static class Task3
{
    public static void Run()
    {
        Console.Write("Rectangle height: ");
        int rectHeight = int.Parse(Console.ReadLine()!);
        Console.Write("Rectangle width: ");
        int rectWidth = int.Parse(Console.ReadLine()!);

        Console.Write("Right triangle height: ");
        int rightHeight = int.Parse(Console.ReadLine()!);

        Console.Write("Equilateral triangle size (rows): ");
        int equilateralSize = int.Parse(Console.ReadLine()!);

        Console.Write("Rhombus half-height (rows above/below center): ");
        int rhombusHalf = int.Parse(Console.ReadLine()!);

        Console.WriteLine();
        Console.WriteLine("--- Rectangle ---");
        DrawRectangle(rectHeight, rectWidth);

        Console.WriteLine();
        Console.WriteLine("--- Right triangle ---");
        DrawRightTriangle(rightHeight);

        Console.WriteLine();
        Console.WriteLine("--- Equilateral triangle ---");
        DrawEquilateralTriangle(equilateralSize);

        Console.WriteLine();
        Console.WriteLine("--- Rhombus ---");
        DrawRhombus(rhombusHalf);
    }

    static void DrawRectangle(int height, int width)
    {
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }

    static void DrawRightTriangle(int height)
    {
        for (int row = 1; row <= height; row++)
        {
            for (int col = 0; col < row; col++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }

    static void DrawEquilateralTriangle(int size)
    {
        for (int row = 0; row < size; row++)
        {
            int spaces = size - row - 1;
            int stars = 2 * row + 1;

            for (int i = 0; i < spaces; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < stars; i++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }
    }

    static void DrawRhombus(int halfHeight)
    {
        if (halfHeight < 1)
        {
            Console.WriteLine("(rhombus size must be at least 1)");
            return;
        }

        for (int row = 0; row < halfHeight; row++)
        {
            int spaces = halfHeight - row - 1;
            int stars = 2 * row + 1;

            for (int i = 0; i < spaces; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < stars; i++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }

        for (int row = halfHeight - 2; row >= 0; row--)
        {
            int spaces = halfHeight - row - 1;
            int stars = 2 * row + 1;

            for (int i = 0; i < spaces; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < stars; i++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }
    }
}
