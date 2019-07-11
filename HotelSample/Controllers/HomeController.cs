using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelSample.Models;

namespace HotelSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext context=new DataContext();

        public IActionResult Index()
        {
            var hotels = context.Hotel.ToList();
            return View(hotels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
