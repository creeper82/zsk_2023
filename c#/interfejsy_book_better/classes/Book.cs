namespace classes;

public class Book : IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public ushort Year { get; set; }
    public float Price { get; set; }

    public Book(string title, string author, ushort year, float price) {
        Title = title;
        Author = author;
        Year = year;
        Price = price;
    }

    public int CompareTo(Book other) {
        if (other is null) return 1;
        return Price.CompareTo(other.Price);
    }
}