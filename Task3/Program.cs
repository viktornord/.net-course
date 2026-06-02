namespace Task3;

internal static class Program
{
    private static void Main()
    {
        var matrix = new MyMatrix(3, 3);
        FillWithSampleValues(matrix);

        Console.WriteLine("Original matrix (3x3):");
        Console.WriteLine(matrix);
        Console.WriteLine();

        matrix.Rows = 4;
        matrix.Columns = 5;
        Console.WriteLine("Resized matrix (4x5):");
        Console.WriteLine(matrix);
        Console.WriteLine();

        matrix.Rows = 2;
        matrix.Columns = 2;
        Console.WriteLine("Resized matrix (2x2):");
        Console.WriteLine(matrix);
    }

    private static void FillWithSampleValues(MyMatrix matrix)
    {
        var value = 1;
        Random random = new Random();
        for (var i = 0; i < matrix.Rows; i++)
        {
            for (var j = 0; j < matrix.Columns; j++)
            {
                matrix[i, j] = random.Next(1, 10);
            }
        }
    }
}
