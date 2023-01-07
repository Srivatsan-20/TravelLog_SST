using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelLog.Models
{
    public class Record
    {
        public int Id { get; set; }
        public string BusNo { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int StartingKm { get; set; }
        public int ClosingKm { get; set; }
        public int TotalKm { get; set; }
        public int AdvanceAmount { get; set; }
        public int Expenses { get; set; }
        public int BalanceAmount { get; set; }
    }

}
