using Microsoft.AspNetCore.Mvc;
using BookApp.Models;
using System;
using System.Collections.Generic;

namespace BookApp.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Display()
        {
            var books = new List<Book>
            {
                new Book { Name = "Book 1", Author = "Author 1", PageNumber = 100, DueDate = DateTime.Now.AddDays(10) },
                new Book { Name = "Book 2", Author = "Author 2", PageNumber = 200, DueDate = DateTime.Now.AddDays(5) },
                new Book { Name = "Book 3", Author = "Author 3", PageNumber = 300, DueDate = DateTime.Now.AddDays(1) }
            };

            return View(books);
        }
    }
}

