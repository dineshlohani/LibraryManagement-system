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
   

        [HttpPost]
        public IActionResult Addbook(Addbook am)
        {
            if(ModelState.IsValid)
            {
                var a = new Addbook()
                {
                   // Id = am.Id,
                    Name = am.Name,
                    Subject = am.Subject,
                    Author = am.Author,
                    Publisher = am.Publisher,
                    Page = am.Page,
                    Isbn = am.Isbn,
                    Copies = am.Copies,
                    Libraryname = am.Libraryname,
                    Shelfno = am.Shelfno,
                    Description = am.Description
                    
                    
                };
                _context.Addbooks.Add(am);// insert the data
                _context.SaveChanges();

                TempData["msg"] = "Data Sucessfulyy entered!!";
                return View();
            }
            else
            {
                TempData["error"] = "Feilds are empty, fill all the fields.";
                return View();
            }

        }
        [HttpPost]
        public IActionResult Dashboard(Dashboard ds)
        {
            if (ModelState.IsValid)
            {
                var d = new Dashboard()
                {
                  Appid = ds.Appid,
                    Name = ds.Name,
                    Email = ds.Email,
                    Number = ds.Number,
                    Birth = ds.Birth,
                    Address = ds.Address,
                    City = ds.City,
                    State = ds.State,
                    Gender = ds.Gender,
                    Image = ds.Image,
                  Course = ds.Course,
                  Zip = ds.Zip,
                  Signature = ds.Signature


                };
                _context.Dashboardss.Add(ds);// insert the data
                _context.SaveChanges();

                TempData["msg"] = "Data Sucessfully entered!!";
                return View();
            }
            else
            {
                TempData["error"] = "Feilds are empty, fill all the fields.";
                return View();
            }

        }
    }
}

        




