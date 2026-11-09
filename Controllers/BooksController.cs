using Microsoft.AspNetCore.Mvc;
using BookCatalogAPI;
namespace BookCatalogAPI.Controllers;

[Route("books")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;
    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    // GET: api/<BooksController>
    [HttpGet]

    public ActionResult<IEnumerable<Books>> FetchBooks([FromQuery] string? author)
    {
        return Ok(_bookService.FetchBooks(author));

    }

    // GET api/<BooksController>/5
    [HttpGet("{id}")]
    public ActionResult<Books> GetBookById(int id)
    {
        var book = _bookService.GetBookById(id);

        if (book is null)
            return NotFound();

        return Ok(book);
    }
    
    // POST api/<BooksController>
    [HttpPost]
    public ActionResult<Books> Create(Books book)
    { 
        var created = _bookService.AddBook(book);

        if (created is null)
            return Conflict($"A book with Id {book.Id} already exists.");   // 409

        return CreatedAtAction(nameof(GetBookById), new { id = created.Id }, created);
    } 
    

    [HttpDelete("{id:int}")]
    public IActionResult DeleteBookById(int id)
    {
        var deleted = _bookService.DeleteBookById(id);
        if (!deleted) return NotFound();                   
        return NoContent();                                
    }

   
    
}
