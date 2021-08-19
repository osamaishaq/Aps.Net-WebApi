using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksServices;

        public BooksController(BooksService bookService)
        {
            _booksServices = bookService;
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVm book)
        {
            _booksServices.AddBook(book);
            return Ok();
        }
    }
}
