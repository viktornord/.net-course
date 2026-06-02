namespace Task4;

internal sealed class Article
{
    private readonly string _productName;
    private readonly string _storeName;
    private readonly decimal _priceInHryvnias;

    public Article(string productName, string storeName, decimal priceInHryvnias)
    {
        _productName = productName;
        _storeName = storeName;
        _priceInHryvnias = priceInHryvnias;
    }

    public string ProductName => _productName;

    public void PrintInfo()
    {
        Console.WriteLine($"Product: {_productName}");
        Console.WriteLine($"Store: {_storeName}");
        Console.WriteLine($"Price: {_priceInHryvnias:F2} UAH");
    }
}
