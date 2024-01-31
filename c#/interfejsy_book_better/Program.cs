using System;
using System.Linq;
using classes;

namespace interfejsy_book;

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = [
        new("Potop", "Henryk Sienkiewicz", 1820, 23.89f),
        new("Nie-boska komedia", "Kra", 1820, 11.89f),
        new("Piesek", "Mariusz R.", 2024, 69.69f)
        ];

        books.Sort();

        Console.WriteLine("wg ceny:");

        foreach (var book in books) Console.WriteLine(book.ToString());

        Console.WriteLine("wg autora malejąco:");

        foreach (var book in books.OrderByDescending(b => b.Author)) Console.WriteLine(book.ToString());

    }
}
