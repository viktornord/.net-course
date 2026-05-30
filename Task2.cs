namespace dot_net_course;

/// <summary>
/// Bank loan repayment: 7 monthly payments of UAH 100 (UAH 700 total).
/// The client may pay in fewer, larger installments (e.g. UAH 300 + UAH 400).
/// </summary>
public static class Task2
{
    private const decimal MonthlyPaymentUah = 100m;
    private const int RequiredPaymentCount = 7;
    private const decimal TotalObligationUah = MonthlyPaymentUah * RequiredPaymentCount;
    private static decimal _remainingDebt = TotalObligationUah;
    private static decimal _overpayment;

    public static void Run()
    {
        Console.WriteLine("Task 2 — Loan repayment");
        Console.WriteLine($"Obligation: {RequiredPaymentCount} payments × UAH {MonthlyPaymentUah} = UAH {TotalObligationUah}");
        Console.WriteLine("Enter payment amounts (UAH). Empty line to exit.");
        Console.WriteLine();

        while (true)
        {
            Console.Write("Payment amount: ");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }

            if (!decimal.TryParse(input, out decimal amount) || amount < 0)
            {
                Console.WriteLine("Enter a valid non-negative number.");
                continue;
            }

            ApplyPayment(amount);
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Records a payment entered by the bank economist and prints the loan state.
    /// </summary>
    public static void ApplyPayment(decimal paymentAmount)
    {
        if (_remainingDebt <= 0)
        {
            _overpayment += paymentAmount;
            PrintLoanState();
            return;
        }

        if (paymentAmount <= _remainingDebt)
        {
            _remainingDebt -= paymentAmount;
        }
        else
        {
            _overpayment += paymentAmount - _remainingDebt;
            _remainingDebt = 0;
        }

        PrintLoanState();
    }

    private static void PrintLoanState()
    {
        Console.WriteLine($"Remaining debt: UAH {_remainingDebt}");

        if (_overpayment > 0)
        {
            Console.WriteLine($"Overpayment: UAH {_overpayment}");
        }

        if (_remainingDebt == 0)
        {
            Console.WriteLine("The loan has been fully repaid. No debt.");
        }
    }
}
