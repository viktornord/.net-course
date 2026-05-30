namespace dot_net_course;

public class Book
{
    public Title title;
    public Author author;
    public Content content;

    public Book(string title, string author, string content)
    {
        this.title = new Title(title);
        this.author = new Author(author);
        this.content = new Content(content);
    }

    public void Show()
    {
        Console.Write("Title: ");
        title.Show();
        Console.Write("Author: ");
        author.Show();
        Console.Write("Content: ");
        content.Show();
    }
}
