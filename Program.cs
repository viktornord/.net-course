if (args.Length == 0)
{
    PrintUsage();
    return;
}

var task = args[0].ToLowerInvariant();

switch (task)
{
    case "2":
    case "task2":
        DotNetCourse.Task2.Run();
        break;
    case "3":
    case "task3":
        DotNetCourse.Task3.Run();
        break;
    case "5":
    case "task5":
        DotNetCourse.Task5.Run();
        break;
    default:
        Console.WriteLine("Unknown task: {0}", args[0]);
        PrintUsage();
        break;
}

static void PrintUsage()
{
    Console.WriteLine("Usage: dotnet run -- <task>");
    Console.WriteLine();
    Console.WriteLine("Tasks:");
    Console.WriteLine("  2  — console calculator (+, -, *, /)");
    Console.WriteLine("  3  — number interval checker (0–100)");
    Console.WriteLine("  5  — Ukrainian–English weather word translator");
    Console.WriteLine();
    Console.WriteLine("Example: dotnet run -- 2");
}
