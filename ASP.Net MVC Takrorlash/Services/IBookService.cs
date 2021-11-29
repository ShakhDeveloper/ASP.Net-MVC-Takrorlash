using ASP.Net_MVC_Takrorlash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_MVC_Takrorlash.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetById(int id);
        Book AddNewBook(Book newBook);
        bool UpdateBook(Book book);
        bool DeleteBook(int id);
    }
}
