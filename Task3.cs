namespace dot_net_course;

public static class Task3
{
    public static int[] MyReverse(int[] array)
    {
        int[] result = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[array.Length - 1 - i];
        }

        return result;
    }

    public static int[] SubArray(int[] array, int index, int count)
    {
        int[] result = new int[count];

        for (int i = 0; i < count; i++)
        {
            int sourceIndex = index + i;
            result[i] = sourceIndex < array.Length ? array[sourceIndex] : 1;
        }

        return result;
    }

    public static void Run()
    {
        int[] sample = { 1, 2, 3, 4, 5, 6, 7, 8 };

        Console.WriteLine($"Original array: {string.Join(", ", sample)}");

        int[] reversed = MyReverse(sample);
        Console.WriteLine($"MyReverse: {string.Join(", ", reversed)}");

        int[] part = SubArray(sample, index: 3, count: 6);
        Console.WriteLine($"SubArray(index=3, count=6): {string.Join(", ", part)}");
        Console.WriteLine("(Elements beyond the original array are filled with 1.)");
    }
}
