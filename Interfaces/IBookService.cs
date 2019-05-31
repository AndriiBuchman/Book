using System.Collections.Generic;
using TestTaskBackEnd.Models;

namespace TestTaskBackEnd.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        bool AddBook(string title, string author);
        Book GetBookById(int id);
    }
}
