using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Highway.Data;

namespace TDDAir.Models
{
    public class Entity : IIdentifiable<int>
    {
        public int Id
        {
            get;
            set;
        }
    }
}