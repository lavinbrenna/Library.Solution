using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

using Library.Models;
namespace Library.Controllers
{
  public class BooksController : Controller
  {
    private readonly LibraryContext _db;

    public BooksController(LibraryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View(_db.Books.ToList());
    }

    [HttpPost]

    public ActionResult Create (Book book, int CustomerId)
    {
      _db.Books.Add(book);
      _db.SaveChanges();
      if(CustomerId != 0)
      {
        _db.CustomerBook.Add(new CustomerBook(){CustomerId = CustomerId, BookId = book.BookId});
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisBook = _db.Books
        .Include(book => book.JoinEntities)
        .ThenInclude(join => join.Customer)
        .FirstOrDefault(book => book.BookId ==id);
      return View(thisBook);
    }

    public ActionResult Edit(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
      ViewBag.CustomerId = new SelectList(_db.Customers, "CustomerId", "Name");
      return View(thisBook);
    }
    [HttpPost]
    public ActionResult Edit(Book book, int CustomerId)
    {
      if(CustomerId != 0)
      {
        _db.CustomerBook.Add(new CustomerBook() {CustomerId = CustomerId, BookId = book.BookId});
      }
      _db.Entry(book).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddCustomer(int id)
    {
      var thisItem = _db.Books.FirstOrDefault(book => book.BookId == id);
      ViewBag.CustomerId = new SelectList(_db.Customers, "CustomerId","Name");
      return View(thisItem);
    }
    [HttpPost]
    public ActionResult AddCustomer(Book book, int CustomerId)
    {
      if (CustomerId != 0)
      {
        _db.CustomerBook.Add(new CustomerBook() {CustomerId = CustomerId, BookId = book.BookId});
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }
  }
}