using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelSample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelSample.Controllers
{
    public class AccountController : Controller
    {
        private DataContext db = new DataContext();
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                var login = db.User.FirstOrDefault(p => p.EmailAddress == user.EmailAddress && p.Password == user.Password);
                if (login != null)
                {
                    HttpContext.Session.SetString("userId", login.Id.ToString());
                    HttpContext.Session.SetString("userName", login.UserName.ToString());
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Email or Password is false.");
                }
            }
            return View(user);
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(User user)
        {
            if (ModelState.IsValid)
            {
                var entity = db.User.FirstOrDefault(i => i.EmailAddress == user.EmailAddress);
                if (entity==null)
                {
                    db.User.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("","This user already exist.");
                }
                      
            }
            return View(user);
        }

        public  IActionResult Logout()
        {
            HttpContext.Session.SetString("userId", "");
            HttpContext.Session.SetString("userName","");
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}