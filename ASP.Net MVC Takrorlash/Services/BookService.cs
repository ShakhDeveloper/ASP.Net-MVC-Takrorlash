using ASP.Net_MVC_Takrorlash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_MVC_Takrorlash.Services
{
    public class BookService : IBookService
    {
        List<Book> allBooks;
        public BookService()
        {
            allBooks = new List<Book>()
            {
                new Book
                {
                    Id = 1,
                    Name = "C# 10 and .Net 6",
                    Author = "Mark J.Price",
                    WTime = DateTime.Now,
                    Price = 39.99
                },
                new Book
                {
                    Id = 2,
                    Name = "C# 9 and .Net 5",
                    Author = "Mark Twen",
                    WTime = DateTime.UtcNow,
                    Price = 34.99
                }
            };

        }
        public Book AddNewBook(Book newBook)
        {
            allBooks.Add(newBook);
            return newBook;
        }

        public bool DeleteBook(int id)
        {
            try
            {
                 allBooks.RemoveAll(b => b.Id == id);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
           
        }

        public List<Book> GetAllBooks()
        {
            return allBooks;
        }

        public Book GetById(int id)
        {
            //foreach(var b in allBooks)
            //{
            //    if (b.Id == id) return b;
            //}
            return allBooks.FirstOrDefault(b => b.Id == id);
        }

        public bool UpdateBook(Book book)
        {
            try
            {
                foreach(var b in allBooks)
                {
                    if(b.Id == book.Id)
                    {
                        b.Name = book.Name;
                        b.Author = book.Author;
                        b.WTime = book.WTime;
                        b.Price = book.Price;
                        break;
                    }
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
