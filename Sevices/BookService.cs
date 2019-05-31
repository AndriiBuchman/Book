using System.Collections.Generic;
using TestTaskBackEnd.Interfaces;
using TestTaskBackEnd.Models;

namespace TestTaskBackEnd.Sevices
{
    public class BookService : IBookService
    {
        private InMemoryRepository<Book> bookRepo;
        private readonly ApplicationContext db;

        public BookService(ApplicationContext context)
        {
            db = context;
            bookRepo = new InMemoryRepository<Book>(context);
        }

        public BookService() { }

        public IEnumerable<Book> GetAllBooks()
        {
            var books = bookRepo.Get();
            return books;
        }

        public bool AddBook(string title, string author)
        {
            if (title == "" || author == "") { return false; }
            else
            {
                Book book = new Book() { Title = title, Author = author };
                bookRepo.Create(book);
                return true;
            }
        }

        public Book GetBookById(int id)
        {
            var book = bookRepo.FindById(id);
            return book;
        }


    }
}
