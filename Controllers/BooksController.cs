using Microsoft.AspNetCore.Mvc;
using BookCatalogAPI;
namespace BookCatalogAPI.Controllers;

[Route("api/v1/books")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    // GET: api/v1/books
    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetAll([FromQuery] string? author)
    {
        var booksResponse = _bookService.GetAll(author).ToList();

        if (!string.IsNullOrWhiteSpace(author) && booksResponse.Count == 0)
            return NotFound($"No books by {author} were found.");

        return Ok(booksResponse);
    }

    // GET: api/v1/books/5
    [HttpGet("{id:int}")]
    public ActionResult<Book> GetById(int id)
    {
        var book = _bookService.GetById(id);

        if (book is null)
            return NotFound();

        return Ok(book);
    }

    // POST: api/v1/books
    [HttpPost]
    public ActionResult<Book> Create(Book book)
    {
        var created = _bookService.Insert(book);

        if (created is null)
            return Conflict($"A book with Id {book.Id} already exists.");

        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    // DELETE: api/v1/books/5
    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        if (!_bookService.Delete(id))
            return NotFound();

        return NoContent();
    }
}
