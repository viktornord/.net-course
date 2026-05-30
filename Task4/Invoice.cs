namespace Task4;

public class Invoice
{
    public readonly int account;
    public readonly string customer;
    public readonly string provider;

    private string _article = string.Empty;
    private int _quantity;

    private const double VatRate = 0.20;

    public Invoice(int account, string customer, string provider)
    {
        this.account = account;
        this.customer = customer;
        this.provider = provider;
    }

    public void SetProductDetails(string article, int quantity)
    {
        _article = article;
        _quantity = quantity;
    }

    private double GetUnitPrice()
    {
        return _article.ToLowerInvariant() switch
        {
            "laptop" => 35000,
            "monitor" => 12000,
            "keyboard" => 2500,
            "mouse" => 800,
            _ => 5000
        };
    }

    public double CalculateTotalWithoutVat()
    {
        return _quantity * GetUnitPrice();
    }

    public double CalculateTotalWithVat()
    {
        return CalculateTotalWithoutVat() * (1 + VatRate);
    }
}
