using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookShop.Models;
using BookShop.Data;

namespace BookShop.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _db;

        public BookController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var books = _db.Books.ToList();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookEntity book)
        {
             _db.Books.Add(book);
             _db.SaveChanges();
             
              return RedirectToAction ();
        }
    }
}
