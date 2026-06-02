namespace Task4;

internal sealed class Store
{
    private readonly Article[] _articles;

    public Store(Article[] articles)
    {
        _articles = articles;
    }

    public void ShowArticleByIndex(int index)
    {
        if (index < 0 || index >= _articles.Length)
        {
            Console.WriteLine("Product with this index was not found.");
            return;
        }

        _articles[index].PrintInfo();
    }

    public void ShowArticleByName(string productName)
    {
        StringComparison comparison = StringComparison.OrdinalIgnoreCase;
        List<Article> productList = _articles.Where(article => string.Equals(article.ProductName, productName, comparison)).ToList();
        productList.ForEach(article => article.PrintInfo());
        if (productList.Count == 0)
        {
            Console.WriteLine("Product with this name was not found.");
        }
    }
}
