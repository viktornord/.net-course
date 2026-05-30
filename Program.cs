using dot_net_course;

if (args.Length == 0)
{
    PrintUsage();
    return;
}

switch (args[0])
{
    case "2":
        Task2.Run();
        break;
    case "3":
        Task3.Run();
        break;
    case "6":
        Task6.Run();
        break;
    default:
        Console.WriteLine($"Unknown task: {args[0]}");
        PrintUsage();
        break;
}

static void PrintUsage()
{
    Console.WriteLine("dot-net-course — homework tasks");
    Console.WriteLine();
    Console.WriteLine("Usage: dotnet run -- <task>");
    Console.WriteLine();
    Console.WriteLine("  2   Loan repayment (UAH 100 × 7 payments)");
    Console.WriteLine("  3   Delivery routes (factorial N!, recursive)");
    Console.WriteLine("  6   Calculate — divide three integers by 5");
    Console.WriteLine();
    Console.WriteLine("Examples:");
    Console.WriteLine("  dotnet run -- 2");
    Console.WriteLine("  dotnet run -- 3");
    Console.WriteLine("  dotnet run -- 6");
}
