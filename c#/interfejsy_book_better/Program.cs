using System;
using classes;

namespace interfejsy_book;

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new();
        books.Add(new("Potop", "Henryk Sienkiewicz", 1820, 23.89f));

        Console.WriteLine(books[0].Title);
    }
}
