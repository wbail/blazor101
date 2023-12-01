using Blazor101.Client.Models;

namespace Blazor101.Client;

public static class BookClient
{
    private static readonly List<Book> books = new()
    {
        new Book()
        {
            Id = 1,
            Name = "1984",
            Genre = "Novel",
            Price = 9.99M,
            ReleaseDate = new DateTime(1940, 1, 1)
        },
        new Book()
        {
            Id = 2,
            Name = "War of the Worlds",
            Genre = "Novel",
            Price = 10.99M,
            ReleaseDate = new DateTime(1890, 1, 1)
        },
        new Book()
        {
            Id = 3,
            Name = "Time Machine",
            Genre = "Novel",
            Price = 7.00M,
            ReleaseDate = new DateTime(1900, 1, 1)
        }
    };

    public static Book[] GetBooks()
    {
        return books.ToArray();
    }

    public static void AddBook(Book book)
    {
        book.Id = books.Max(book => book.Id) + 1;
        books.Add(book);
    }

    public static Book GetBook(int id)
    {
        return books.Find(book => book.Id == id) ?? throw new Exception("Could not find the book!");
    }

    public static void UpdateBook(Book updatedBook)
    {
        Book existingBook = GetBook(updatedBook.Id);
        existingBook.Name = updatedBook.Name;
        existingBook.Genre = updatedBook.Genre;
        existingBook.Price = updatedBook.Price;
        existingBook.ReleaseDate = updatedBook.ReleaseDate;
    }

    public static void DeleteBook(int id)
    {
        Book book = GetBook(id);

        books.Remove(book);
    }
}
