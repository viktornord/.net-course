namespace Task4;

internal static class Program
{
    private static void Main()
    {
        var store = new Store(
        [
            new Article("Milk", "ATB", 45.50m),
            new Article("Bread", "Silpo", 29.90m),
            new Article("Coffee", "Novus", 189.00m),
            new Article("Apples", "Varus", 62.75m)
        ]);

        Console.Write("Enter product index (0-3): ");
        if (int.TryParse(Console.ReadLine(), out var index))
        {
            store.ShowArticleByIndex(index);
        }
        else
        {
            Console.WriteLine("Invalid index input.");
        }

        Console.WriteLine();
        Console.Write("Enter product name: ");
        var productName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(productName))
        {
            Console.WriteLine("Product name cannot be empty.");
            return;
        }

        store.ShowArticleByName(productName.Trim());
    }
}
