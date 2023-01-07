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
      //  public DbSet<Booking> Bookings { get; set; }
        public void Seed(ModelBuilder modelBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }

}
