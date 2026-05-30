namespace dot_net_course;

internal static class Program
{
    private static void Main(string[] args)
    {
        if (args.Length > 0 && TryRunTask(args[0]))
        {
            return;
        }

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Select a task to run:");
            Console.WriteLine("  2 - Array statistics (size N, max, min, sum, mean, odd values)");
            Console.WriteLine("  3 - MyReverse and SubArray");
            Console.WriteLine("  4 - Increase array length / add element at index 0");
            Console.WriteLine("  6 - Display 10 elements in reverse order");
            Console.WriteLine("  q - Quit");
            Console.Write("Enter task number: ");

            string? input = Console.ReadLine()?.Trim().ToLowerInvariant();
            if (input is "q" or "quit" or "exit")
            {
                break;
            }

            if (!TryRunTask(input ?? string.Empty))
            {
                Console.WriteLine("Unknown task. Enter 2, 3, 4, 6, or q.");
            }
        }
    }

    private static bool TryRunTask(string taskNumber)
    {
        switch (taskNumber)
        {
            case "2":
                Task2.Run();
                return true;
            case "3":
                Task3.Run();
                return true;
            case "4":
                Task4.Run();
                return true;
            case "6":
                Task6.Run();
                return true;
            default:
                return false;
        }
    }
}
