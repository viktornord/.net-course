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
    case "4":
    case "task4":
        DotNetCourse.Task4.Run();
        break;
    case "6":
    case "task6":
        DotNetCourse.Task6.Run();
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
    Console.WriteLine("  2  — arithmetic operations (+, -, *, /)");
    Console.WriteLine("  3  — currency conversion");
    Console.WriteLine("  4  — sign, prime check, divisibility");
    Console.WriteLine("  6  — arithmetic mean of three integers");
    Console.WriteLine();
    Console.WriteLine("Example: dotnet run -- 2");
}
