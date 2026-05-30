using DotNetCourse.Tasks;

if (args.Length == 0)
{
    PrintUsage();
    return;
}

switch (args[0].ToLowerInvariant())
{
    case "1":
        Task1.Run();
        break;
    case "2":
        Task2.Run();
        break;
    case "3":
        Task3.Run();
        break;
    default:
        Console.WriteLine($"Unknown task: {args[0]}");
        PrintUsage();
        break;
}

static void PrintUsage()
{
    Console.WriteLine("Homework tasks — run one at a time:");
    Console.WriteLine("  dotnet run -- 1   # acronyms, types, ranges, defaults");
    Console.WriteLine("  dotnet run -- 2   # pi and e (decimal precision)");
    Console.WriteLine("  dotnet run -- 3   # string escape sequences");
    Console.WriteLine("  dotnet run --project Task5   # same GUI, Task5 project only");
}
