using System;

public class BookService : IBookService
{
    private readonly List<Books> _books = new()
    {
        new Books
        {
            Id = 1,
            Title = "The Last Summer",
            Author = "Joy",
            CopiesAvailable = 5
        },
        new Books
        {
            Id = 2,
            Title = "Life",
            Author = "Alex",
            CopiesAvailable = 5
        },
        new Books
        {
            Id = 3,
            Title = "Magic",
            Author = "John Boss",
            CopiesAvailable = 2
        }
    };
    public IEnumerable<Books> FetchBooks(string? author)
    {
        if (string.IsNullOrWhiteSpace(author))
        {
            return _books;
        }

        return _books.Where(b =>
       string.Equals(b.Author, author, StringComparison.OrdinalIgnoreCase));
    }
    public Books? GetBookById(int id)
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
 public Books AddBook(Books book)
    {
        if (_books.Any(b => b.Id == book.Id))
            return null;

        _books.Add(book);
        return book;
    }
    public bool DeleteBookById(int id)
    {
        var book = GetBookById(id);
        if (book is null) return false;   
        _books.Remove(book);
        return true;
    }
}