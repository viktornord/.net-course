using Task4;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Account number: ");
int.TryParse(Console.ReadLine(), out int account);

Console.Write("Customer: ");
string customer = Console.ReadLine()?.Trim() ?? string.Empty;

Console.Write("Provider: ");
string provider = Console.ReadLine()?.Trim() ?? string.Empty;

Console.Write("Article (laptop, monitor, keyboard, mouse): ");
string article = Console.ReadLine()?.Trim() ?? string.Empty;

Console.Write("Quantity: ");
int.TryParse(Console.ReadLine(), out int quantity);

var invoice = new Invoice(account, customer, provider);
invoice.SetProductDetails(article, quantity);

double totalWithoutVat = invoice.CalculateTotalWithoutVat();
double totalWithVat = invoice.CalculateTotalWithVat();

Console.WriteLine();
Console.WriteLine("Total amount to be paid for the product:");
Console.WriteLine($"Without VAT: {totalWithoutVat:F2} UAH");
Console.WriteLine($"With VAT: {totalWithVat:F2} UAH");
