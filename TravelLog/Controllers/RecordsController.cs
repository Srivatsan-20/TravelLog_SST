using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelLog.Data;
using TravelLog.Models;

namespace TravelLog.Controllers
{
    public class RecordsController : Controller
    {
        private readonly RecordContext _context;

        public RecordsController(RecordContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var records = await _context.Records.ToListAsync();
            return View(records);
        }

        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // Get the data for the new record from the form collection
                string busNo = collection["BusNo"];
                DateTime fromDate = DateTime.Parse(collection["FromDate"]);
                DateTime toDate = DateTime.Parse(collection["ToDate"]);
                int startingKm = int.Parse(collection["StartingKm"]);
                int closingKm = int.Parse(collection["ClosingKm"]);
                int totalKm = closingKm - startingKm;
                int advanceAmount = int.Parse(collection["AdvanceAmount"]);
                int expenses = int.Parse(collection["Expenses"]);
                int balanceAmount = advanceAmount - expenses;

                // Create a new Record object with the data
                Record record = new Record
                {
                    BusNo = busNo,
                    FromDate = fromDate,
                    ToDate = toDate,
                    StartingKm = startingKm,
                    ClosingKm = closingKm,
                    TotalKm = totalKm,
                    AdvanceAmount = advanceAmount,
                    Expenses = expenses,
                    BalanceAmount = balanceAmount
                };

                // Add the Record object to the DbSet<Record> in the context class
                _context.Records.Add(record);

                // Save the changes to the database
                _context.SaveChanges();

                // Redirect to the Index action method
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                // An error occurred, so return the Create view
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            Record record = _context.Records.Find(id);
            if (record == null)
            {
                return NotFound();
            }
            return View(record);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Record record = _context.Records.Find(id);
            _context.Records.Remove(record);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            // Find the record with the specified id
            var record = _context.Records.Find(id);

            // If the record was not found, return a 404 error
            if (record == null)
            {
                return NotFound();
            }

            // Otherwise, return the Edit view and pass the record as the model
            return View(record);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            // code to retrieve and display the record for editing
            var record = _context.Records.Find(id);
            if (record == null)
            {
                return NotFound();
            }
            return View(record);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,BusNo,FromDate,ToDate,StartingKm,ClosingKm,TotalKm,AdvanceAmount,Expenses,BalanceAmount")] Record record)
        {
            if (id != record.Id)
            {
                return NotFound();
            }

            // Calculate TotalKm and BalanceAmount
            record.TotalKm = record.ClosingKm - record.StartingKm;
            record.BalanceAmount = record.AdvanceAmount - record.Expenses;


            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(record);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecordExists(record.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(record);
        }

        private bool RecordExists(int id)
        {
            return _context.Records.Any(e => e.Id == id);
        }

       
    }

}
