using libApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace libApp.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Random()
        {
            var firstBook = new Book()
            {
                Name = "Law and punishment"
            };


            return View(firstBook);
        }


        public IActionResult Index(int pageIndex = 1, string sortBy = "Name") => Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        

        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }
    }
}
