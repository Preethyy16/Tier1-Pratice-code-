using System;
using System.Xml.Linq;

public class BookService : IBookService
{
    private readonly List<Book> _books = PopulateBooksList();

    private static List<Book> PopulateBooksList()
    {
        return new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "The Last Summer",
                Author = "Joy",
                CopiesAvailable = 5
            },
            new Book
            {
                Id = 2,
                Title = "Life",
                Author = "Alex",
                CopiesAvailable = 5
            },
            new Book
            {
                Id = 3,
                Title = "Magic",
                Author = "John Boss",
                CopiesAvailable = 2
            }
        };
    }

    public IEnumerable<Book> GetAll(string? author)
    {
        if (string.IsNullOrWhiteSpace(author))
        {
            return _books;
        }

        return _books.Where(b =>
            string.Equals(b.Author, author, StringComparison.OrdinalIgnoreCase));
    }

    public Book? GetById(int id)
    {
        foreach (var book in _books)
        {
            if (book.Id == id)
            {
                return book;
            }
        }
        return null;
    }

    public Book? Insert(Book book)
    {
        if (_books.Any(b => b.Id == book.Id))
            return null;

        _books.Add(book);
        return book;
    }

    public bool Delete(int id)
    {
        var book = GetById(id);
        if (book is null) return false;

        _books.Remove(book);
        return true;
    }
}