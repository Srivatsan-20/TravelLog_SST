using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelLog.Models;

namespace TravelLog.Data
{
    public class RecordContext : DbContext
    {
        public RecordContext(DbContextOptions<RecordContext> options)
            : base(options)
        { }

        public DbSet<Record> Records { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Record>().HasData(
        new Record { Id = 1, BusNo = "123", FromDate = DateTime.Now, ToDate = DateTime.Now, StartingKm = 0, ClosingKm = 100, TotalKm = 100, AdvanceAmount = 1000, Expenses = 500, BalanceAmount = 500 },
        new Record { Id = 2, BusNo = "456", FromDate = DateTime.Now, ToDate = DateTime.Now, StartingKm = 0, ClosingKm = 200, TotalKm = 200, AdvanceAmount = 2000, Expenses = 1000, BalanceAmount = 1000 }
    );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }

}
