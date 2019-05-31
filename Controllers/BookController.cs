using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestTaskBackEnd.DTOs;
using TestTaskBackEnd.Interfaces;
using TestTaskBackEnd.Models;

namespace TestTaskBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        InMemoryRepository<Book> bookRepo;

        private IBookService _bookService;
        public BookController(IBookService bookService, ApplicationContext context)
        {
            bookRepo = new InMemoryRepository<Book>(context);
            _bookService = bookService;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            var dto = _bookService.GetAllBooks();
            return dto;
        }

        [HttpPost]
        public ActionResult Post([FromBody] BookDTO bookDTO)
        {
            if (ModelState.IsValid)
            {
                _bookService.AddBook(bookDTO.Title, bookDTO.Author);
               return Ok();
            }
            else
            {
                return new NotFoundResult();
            }
        }


    }
}