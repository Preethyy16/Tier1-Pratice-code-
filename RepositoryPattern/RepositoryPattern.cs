using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.RepositoryPattern
{
   using System;
    using System.Collections.Generic;
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } 
    }
    public class BookRepository
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added");
        }

        public void GetBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.Id + " " + book.Title);
            }
        }
    }

}