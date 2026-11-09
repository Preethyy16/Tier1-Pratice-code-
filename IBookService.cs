using System;
using System.Collections.Generic;
 
    public interface IBookService
    {
        IEnumerable<Books> FetchBooks(string? author);
        Books? GetBookById(int id);
        Books AddBook(Books book);
        bool DeleteBookById(int id);
    }   