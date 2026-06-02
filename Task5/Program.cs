namespace Task5;

internal static class Program
{
    private static void Main()
    {
        Book book = new Book(
            "The Great Gatsby",
            "F. Scott Fitzgerald",
            "In my younger and more vulnerable years my father gave me some advice."
        );

        book.Show();
    }
}

