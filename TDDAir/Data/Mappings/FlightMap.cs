﻿using System.Data.Entity.ModelConfiguration;
using TDDAir.Models;

namespace TDDAir.Data.Mappings
{
    public class FlightMap : EntityTypeConfiguration<Flight>
    {
        public FlightMap()
        {
            HasRequired<Flier>(f => f.Flier).WithOptional();
        }
    }
}