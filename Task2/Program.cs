using Task2;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Converter converter = new Converter(usd: 41.50, eur: 44.80, gbp: 52.30);

Console.WriteLine("Currency Converter (UAH ↔ USD / EUR / GBP)");
Console.WriteLine("Exchange rates (UAH per 1 unit): USD=41.50, EUR=44.80, GBP=52.30");
Console.WriteLine();

while (true)
{
    Console.WriteLine("Choose conversion:");
    Console.WriteLine("1 — UAH → USD");
    Console.WriteLine("2 — UAH → EUR");
    Console.WriteLine("3 — UAH → GBP");
    Console.WriteLine("4 — USD → UAH");
    Console.WriteLine("5 — EUR → UAH");
    Console.WriteLine("6 — GBP → UAH");
    Console.Write("Your choice: ");

    if (!int.TryParse(Console.ReadLine(), out int choice) || choice is < 1 or > 6)
    {
        Console.WriteLine("Invalid input. Try again.\n");
        continue;
    }

    Console.Write("Enter amount: ");
    if (!double.TryParse(Console.ReadLine(), out double amount) || amount < 0)
    {
        Console.WriteLine("Invalid amount. Try again.\n");
        continue;
    }

    double result = choice switch
    {
        1 => converter.ToUsd(amount),
        2 => converter.ToEur(amount),
        3 => converter.ToGbp(amount),
        4 => converter.FromUsd(amount),
        5 => converter.FromEur(amount),
        6 => converter.FromGbp(amount),
        _ => 0
    };

    (string fromCurrency, string toCurrency) = choice switch
    {
        1 => ("UAH", "USD"),
        2 => ("UAH", "EUR"),
        3 => ("UAH", "GBP"),
        4 => ("USD", "UAH"),
        5 => ("EUR", "UAH"),
        6 => ("GBP", "UAH"),
        _ => (string.Empty, string.Empty)
    };

    Console.WriteLine($"Result: {amount:F2} {fromCurrency} = {result:F2} {toCurrency}\n");
}
