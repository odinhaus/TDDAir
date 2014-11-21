using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Highway.Data;

namespace TDDAir.Models
{
    public enum FlierStatus
    {
        Red,
        Yellow,
        Green
    }

    public class Flier : Entity
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public FlierStatus Status { get; set; }
        public int LifetimeMiles { get; set; }
        public int AnnualMiles { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }
}