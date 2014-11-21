using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TDDAir.Models;

namespace TDDAir.Data.Logic
{
    public class FlightLogic : BaseLogic<Flight>
    {
        protected override Flight Apply(Flight model)
        {
            return model;
        }
    }
}