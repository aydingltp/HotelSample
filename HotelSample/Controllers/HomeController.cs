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
        private readonly DataContext db = new DataContext();

        //public IActionResult Index()
        //{
        //    var hotels = db.Hotel.ToList();
        //    return View(hotels);
        //}
        public IActionResult Index(string q)
        {
            var hotels = db.Hotel.AsQueryable();

            if (q != null)
            {
                hotels = hotels.Where(i => i.Name.Contains(q) || i.Description.Contains(q));
                return View(hotels.ToList());
            }
            else
            {
                return View(hotels.ToList());
            }
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
