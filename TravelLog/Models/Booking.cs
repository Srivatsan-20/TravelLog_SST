using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelLog.Models
{
    public class Booking
    {
        public int AggrementNumber { get; set; }
        public DateTime BookingDate { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int NumberofDays { get; set; }
        public string Places { get; set; }
        public int RentPerDay { get; set; }
        public int RentForDays { get; set; }
        public int HillsRent { get; set; }
        public int TotalRent { get; set; }
        public int Advance { get; set; }
        public int Balance { get; set; }
    }

}
