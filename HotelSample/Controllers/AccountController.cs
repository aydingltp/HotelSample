using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelSample.Models;
using HotelSample.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace HotelSample.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel user)
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(User user)
        {
            return View();
        }
    }
}