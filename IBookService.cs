using System;
using System.Collections.Generic;
 
    public interface IBookService
    {
        IEnumerable<Book> GetAll(string? author);
        Book? GetById(int id);
        Book? Insert(Book book);
        bool Delete(int id);
    }   