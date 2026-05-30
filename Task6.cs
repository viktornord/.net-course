namespace dot_net_course;

public static class Task6
{
    public static void Run()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine($"Array (10 elements): {string.Join(", ", array)}");
        Console.Write("Elements in reverse order: ");

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
            if (i > 0)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}
