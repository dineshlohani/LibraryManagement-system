using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    public class AuthController : Controller
    {
        public DatabaseContext _context;
        public AuthController(DatabaseContext context)
        {
            _context = context;
        }
        public ViewResult Signup()
        {
            return View();
        }

        public ViewResult Login()
        {
            return View();
        }

        public ViewResult Dashboard()
        {
            return View();
        }

        public ViewResult Addbook()
        {
            return View();
        }

        public ViewResult Book()
        {
            return View();
        }


        public ViewResult Vehicle()
        {
            return View();
        }

        public ViewResult addService()
        {
            return View();
        }
        public ViewResult Remove()
        {
            return View();
        }
        public ViewResult Removemember()
        {
            return View();
        }
        public ViewResult SearchBook()
        {
            return View();
        }
        public ViewResult Borrow()
        {
            return View();
        }
        public ViewResult Return()
        {
            return View();
        }
        public ViewResult Ticket()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Addbook am)
        {
            if(ModelState.IsValid)
            {
                var a = new Addbook()
                {
                    Name = am.Name,
                    Subject = am.Subject,
                    Author = am.Author,
                    Publisher = am.Publisher,
                    Page = am.Page,
                    Isbn = am.Isbn,
                    Copies = am.Copies,
                    Libraryname = am.Libraryname,
                    Shelfno = am.Shelfno,
                    Description = am.Description,
                    

                };
                _context.Addbooks.Add(a);// insert the data
                _context.SaveChanges();
                TempData["msg"] = "Data Sucessfulyy entered!!";
                return View();
            }
            else
            {
                TempData["error"] = "Feilds are empty, fill all the fields.";
                return View();
            }
            return View();
        }
    }
}
