namespace Anghel_Radu_Lab2.Models;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<Book>? Books { get; set; }
}

public class Publisher
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<Book>? Books { get; set; }
}

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int PublisherId { get; set; }
    public Publisher? Publisher { get; set; }
    public ICollection<Author>? Authors { get; set; }
}
