using ASP.Net_MVC_Takrorlash.Models;
using ASP.Net_MVC_Takrorlash.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_MVC_Takrorlash.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;

        public HomeController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public ViewResult Index()
        {
            //ViewData["Kalit"] = 909;
            //ViewBag.Sarlavha = "Bu index file";

            List<Book> books = _bookService.GetAllBooks();

            return View("Index",books);
        }

        public ViewResult Private()
        {
            return View("MyView");
        }
    }
}
