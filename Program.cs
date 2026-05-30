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
    case "7":
    case "task7":
        DotNetCourse.Task7.Run();
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
    Console.WriteLine("  2  — parity check (modulo and LSB)");
    Console.WriteLine("  3  — bitwise expression evaluation (x, y, z)");
    Console.WriteLine("  4  — employee bonus by seniority");
    Console.WriteLine("  6  — power-of-two check");
    Console.WriteLine("  7  — De Morgan: A | B as ~(~A & ~B)");
    Console.WriteLine();
    Console.WriteLine("Example: dotnet run -- 2");
}
