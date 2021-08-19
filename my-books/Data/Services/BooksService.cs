using my_books.Data.Models;
using my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Services
{
    public class BooksService
    {
        //Making Refrence for the Db COntext
        private AppDbContext _context; //Inilizing variable
        public BooksService(AppDbContext context)
        {
            //placing context to that variable
            _context = context;
        }

        public void AddBook(BookVm book)
        {
            var _book = new Book() 
            { 
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.DateRead.Value : null,
                Rate = book.IsRead ? book.Rate.Value : null,
                Genre = book.Genre,
                CoverUrl = book.CoverUrl,
                Author = book.Author,
                DateAdded = DateTime.Now
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }
    }
}
