using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AmazonBooks.Models;
using AmazonBooks.Data;

namespace AmazonBooks.Controllers;

public class BookController : Controller
{
    private ApplicationDbContext_db

    public BookController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        var books=_db.Books.ToList();
        return View();
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
     public IActionResult CreateBoot(BooksEntity book)
    {
         _db.books.Add(book);
         _db.SaveChanges();

         return RedirectToAction("Index");
    }

}