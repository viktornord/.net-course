namespace DotNetCourse;

/// <summary>
/// Task 2: Arithmetic operations (Add, Sub, Mul, Div) with keyboard input.
/// </summary>
public static class Task2
{
    public static void Run()
    {
        Console.Write("Enter first operand: ");
        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Enter second operand: ");
        int b = int.Parse(Console.ReadLine()!);

        Console.Write("Enter operation (+, -, *, /): ");
        string op = Console.ReadLine()!.Trim();

        switch (op)
        {
            case "+":
                Add(a, b);
                break;
            case "-":
                Sub(a, b);
                break;
            case "*":
                Mul(a, b);
                break;
            case "/":
                Div(a, b);
                break;
            default:
                Console.WriteLine("Unknown operation: {0}", op);
                break;
        }
    }

    static void Add(int a, int b)
    {
        int result = a + b;
        Console.WriteLine("Add: {0} + {1} = {2}", a, b, result);
    }

    static void Sub(int a, int b)
    {
        int result = a - b;
        Console.WriteLine("Sub: {0} - {1} = {2}", a, b, result);
    }

    static void Mul(int a, int b)
    {
        int result = a * b;
        Console.WriteLine("Mul: {0} * {1} = {2}", a, b, result);
    }

    static void Div(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Div: division by zero is not allowed ({0} / {1}).", a, b);
            return;
        }

        int result = a / b;
        Console.WriteLine("Div: {0} / {1} = {2}", a, b, result);
    }
}
