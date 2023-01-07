using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelLog.Data;
using TravelLog.Models;

namespace TravelLog.Controllers
{
    public class Bookings : Controller
    {
        private readonly RecordContext _context;

        public Bookings(RecordContext context)
        {
            _context = context;
        }
        // GET: Bookings
        public ActionResult Index()
        {
            return View();
        }

        // GET: Bookings/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bookings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bookings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult View(IFormCollection collection)
        {
            try
            {
                var agreementNumber = Convert.ToInt32(collection["AggrementNumber"]);
                var bookingDate = Convert.ToDateTime(collection["BookingDate"]);
                var name = collection["Name"];
                var address = collection["Address"];
                var phoneNumber = collection["PhoneNumber"];
                var fromDate = Convert.ToDateTime(collection["FromDate"]);
                var toDate = Convert.ToDateTime(collection["ToDate"]);
                var numberOfDays = Convert.ToInt32(collection["NumberOfDays"]);
                var places = collection["Places"];
                var rentPerDay = Convert.ToInt32(collection["RentPerDay"]);
                var rentForDays = Convert.ToInt32(collection["RentForDays"]);
                var hillsRent = Convert.ToInt32(collection["HillsRent"]);
                var totalRent = Convert.ToInt32(collection["TotalRent"]);
                var advance = Convert.ToInt32(collection["Advance"]);
                var balance = Convert.ToInt32(collection["Balance"]);

                // Create a new instance of the model class
                var booking = new Booking
                {
                    AggrementNumber = agreementNumber,
                    BookingDate = bookingDate,
                    Name = name,
                    Address = address,
                    PhoneNumber = phoneNumber,
                    FromDate = fromDate,
                    ToDate = toDate,
                    NumberofDays = numberOfDays,
                    Places = places,
                    RentPerDay = rentPerDay,
                    RentForDays = rentForDays,
                    HillsRent = hillsRent,
                    TotalRent = totalRent,
                    Advance = advance,
                    Balance = balance
                };
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Bookings/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bookings/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Bookings/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bookings/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
