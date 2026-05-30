namespace dot_net_course;

public static class Task4
{
    public static int[] IncreaseLengthByOne(int[] array)
    {
        int[] result = new int[array.Length + 1];
        Array.Copy(array, result, array.Length);
        return result;
    }

    public static int[] AddAtStart(int[] array, int value)
    {
        int[] result = new int[array.Length + 1];
        result[0] = value;
        Array.Copy(array, 0, result, 1, array.Length);
        return result;
    }

    public static void Run()
    {
        int[] array = { 10, 20, 30, 40 };

        Console.WriteLine($"Original array: {string.Join(", ", array)}");

        int[] longer = IncreaseLengthByOne(array);
        Console.WriteLine($"After IncreaseLengthByOne: {string.Join(", ", longer)}");

        int[] withValueAtStart = AddAtStart(array, value: 5);
        Console.WriteLine($"After AddAtStart(5): {string.Join(", ", withValueAtStart)}");
    }
}
