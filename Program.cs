if (args.Length == 0)
{
    PrintUsage();
    return;
}

var task = args[0].ToLowerInvariant();

switch (task)
{
    case "1":
    case "task1":
        DotNetCourse.Task1.Run();
        break;
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
    case "5":
    case "task5":
        DotNetCourse.Task5.Run();
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
    Console.WriteLine("  1  — increment/decrement expressions");
    Console.WriteLine("  2  — arithmetic mean of three integers");
    Console.WriteLine("  3  — circle area (πr²)");
    Console.WriteLine("  4  — cylinder volume and surface area");
    Console.WriteLine("  5  — valid/invalid identifier names");
    Console.WriteLine("  7  — arithmetic operations on two integers");
    Console.WriteLine();
    Console.WriteLine("Example: dotnet run -- 1");
}
