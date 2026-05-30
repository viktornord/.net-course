namespace DotNetCourse;

/// <summary>
/// Task 2: Parity check — even numbers have least significant bit 0.
/// </summary>
public static class Task2
{
    public static void Run()
    {
        Console.Write("Enter an integer to check parity: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Number: {0}", number);
        Console.WriteLine();

        bool evenByModulo = number % 2 == 0;
        Console.WriteLine("Option 1 — modulo (n % 2 == 0):");
        Console.WriteLine("  {0} is {1}.", number, evenByModulo ? "even" : "odd");

        bool evenByBit = (number & 1) == 0;
        Console.WriteLine();
        Console.WriteLine("Option 2 — least significant bit / LSB ((n & 1) == 0):");
        Console.WriteLine("  Binary (last 8 bits): {0}", Convert.ToString(number & 0xFF, 2).PadLeft(8, '0'));
        Console.WriteLine("  LSB = {0} → {1}.", number & 1, evenByBit ? "even" : "odd");
    }
}
