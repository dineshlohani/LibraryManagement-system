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
       public ViewResult Index()

        {
            var addbooks = _context.Addbooks.ToList();  //Select * from Addbook
            return View(addbooks);
        }

        public ViewResult Register()

        {
            var register = _context.Addbooks.ToList();  //Select * from Addbook
            return View(register);
        
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
            if (ModelState.IsValid)
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
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Feilds are empty, fill all the fields.";
                return View();
            }


        }
        
        [HttpPost]
        public IActionResult Remove(int id)
        {
            var am = _context.Addbooks.SingleOrDefault(a => a.Id == id); // select * form Addbook where id = "id"
            _context.Addbooks.Remove(am);//delete
            _context.SaveChanges();
            TempData["msg"] = "Deleted Successfully!!";
            return RedirectToAction("Index");
        }
      
        [HttpPost]
        public IActionResult Edit(Addbook a)
        {
            if (ModelState.IsValid)
            {
                var am = new Addbook()
                {
                    Id = a.Id,
                    Name = a.Name,
                    Subject = a.Subject,
                    Author = a.Author,
                    Publisher = a.Publisher,
                    Page = a.Page,
                    Isbn = a.Isbn,
                    Copies = a.Copies,
                    Libraryname = a.Libraryname,
                    Shelfno = a.Shelfno,
                    Description = a.Description
                };
                _context.Addbooks.Update(am);
                _context.SaveChanges();
                TempData["Msg"] = "Successfully Upadated!!";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "some error occure";
                return View();
            }
           
        }


        [HttpPost]
        public IActionResult Dashboard(Dashboard am)
        {
            if (ModelState.IsValid)
            {
                var a = new Dashboard()
                {
                    
                    Appid = am.Appid,
                    Name = am.Name,
                   Email = am.Email,
                    Number = am.Number,
                    Birth = am.Birth,
                    Address = am.Address,
                    City = am.City,
                    State = am.State,
                    Gender = am.Gender,
                   // Image = ds.Image,
                  Course = am.Course,
                  Zip = am.Zip,
                  //Signature = ds.Signature


                };
                _context.Dashboardss.Add(a);// insert the data
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

        




