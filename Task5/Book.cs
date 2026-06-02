namespace Task5;

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
        title.Show();
        author.Show();
        content.Show();
    }
}

