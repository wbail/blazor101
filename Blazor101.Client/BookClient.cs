using Blazor101.Client.Models;

namespace Blazor101.Client;

public static class BookClient
{
    private static readonly List<Book> books = new()
    {
        new Book()
        {
            Id = Guid.Parse("5adbf596-01ff-40b4-a2a3-3a34a1f9ddaf"),
            Name = "1984",
            Genre = "Novel",
            Price = 9.99M,
            ReleaseDate = new DateTime(1940, 1, 1)
        },
        new Book()
        {
            Id = Guid.Parse("4dee6a3e-22a8-424a-8e05-cf964238dd69"),
            Name = "War of the Worlds",
            Genre = "Novel",
            Price = 10.99M,
            ReleaseDate = new DateTime(1890, 1, 1)
        },
        new Book()
        {
            Id = Guid.Parse("fe62a0eb-4085-42fc-9ff1-34822540b7ef"),
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
        book.Id = Guid.NewGuid();
        books.Add(book);
    }

    public static Book GetBook(Guid id)
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

    public static void DeleteBook(Guid id)
    {
        Book book = GetBook(id);

        books.Remove(book);
    }
}
