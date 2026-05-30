namespace DotNetCourse;

/// <summary>
/// Task 2: Console calculator with switch and division-by-zero check.
/// </summary>
public static class Task2
{
    public static void Run()
    {
        double operand1 = 12.5;
        double operand2 = 4.0;

        Console.WriteLine("Operand 1: {0}", operand1);
        Console.WriteLine("Operand 2: {0}", operand2);
        Console.Write("Enter the sign of the arithmetic operation (+, -, *, /): ");
        string? sign = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(sign))
        {
            Console.WriteLine("No operation sign entered.");
            return;
        }

        sign = sign.Trim();

        switch (sign)
        {
            case "+":
                Console.WriteLine("Result: {0}", operand1 + operand2);
                break;
            case "-":
                Console.WriteLine("Result: {0}", operand1 - operand2);
                break;
            case "*":
                Console.WriteLine("Result: {0}", operand1 * operand2);
                break;
            case "/":
                if (operand2 == 0)
                {
                    Console.WriteLine("Error: division by zero is not allowed.");
                }
                else
                {
                    Console.WriteLine("Result: {0}", operand1 / operand2);
                }
                break;
            default:
                Console.WriteLine("Unknown operation sign: {0}", sign);
                break;
        }
    }
}
