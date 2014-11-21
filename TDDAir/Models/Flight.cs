using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDDAir.Models
{
    public class Flight : Entity
    {
        public string Name { get; set; }
        public int Distance { get; set; }
        public Flier Flier { get; set; }
    }
}