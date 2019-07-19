using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelSample.Models;

namespace HotelSample.Controllers
{
    public class HotelController : Controller
    {
        private HotelDBContext _context = new HotelDBContext();


        // GET: Hotel
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hotel.ToListAsync());
        }

        // GET: Hotel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _context.Hotel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }

        // GET: Hotel/Create
        public IActionResult Create2()
        {
            return View();
        }

        // POST: Hotel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create2(HotelViewModel hotel)
        {
            if (ModelState.IsValid)
            {
                var entityHotel = new Hotel
                {
                    Name = hotel.Name,
                    Description = hotel.Description
                };
                entityHotel.HotelAddress.Add(new HotelAddress
                {
                    HotelId = hotel.Id,
                    AddressText = hotel.AddressText,
                    PostalCode = hotel.PostalCode,
                    CityId = hotel.CityId
                });
                entityHotel.HotelRoom.Add(new HotelRoom
                {
                    HotelId = hotel.Id,
                    RoomTypeId=hotel.RoomTypeId,
                    RoomDetail = hotel.RoomDetail,
                    RoomSummary = hotel.RoomSummary,
                });
                entityHotel.HotelImage.Add(new HotelImage
                {
                    HotelId = hotel.Id,
                    ImagePath = hotel.ImagePath,
                    Description = hotel.Description
                });
                entityHotel.HotelContact.Add(new HotelContact
                {
                    HotelId = hotel.Id,
                    HotelContactTypeId = hotel.HotelContactTypeId,
                    ContactValue = hotel.ContactValue
                });
                //_context.HotelContact.Add(new HotelContact
                //{
                //    HotelId = hotel.Id,
                //    HotelContactTypeId = hotel.HotelContactTypeId,
                //    ContactValue = hotel.ContactValue,
                //});
                entityHotel.HotelScore.Add(
                    new HotelScore
                    {
                        HotelId=hotel.Id,
                        HotelScoreTypeId=hotel.HotelScoreTypeId,
                        ScoreValue=hotel.ScoreValue
                    }
                );
                _context.Hotel.Add(entityHotel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hotel);
        }

        // GET: Hotel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _context.Hotel.FindAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return View(hotel);
        }

        // POST: Hotel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] Hotel hotel)
        {
            if (id != hotel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hotel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelExists(hotel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(hotel);
        }

        // GET: Hotel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _context.Hotel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }

        // POST: Hotel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hotel = await _context.Hotel.FindAsync(id);
            _context.Hotel.Remove(hotel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HotelExists(int id)
        {
            return _context.Hotel.Any(e => e.Id == id);
        }
    }
}
