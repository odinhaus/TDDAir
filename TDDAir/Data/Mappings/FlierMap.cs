﻿using System.Data.Entity.ModelConfiguration;
using TDDAir.Models;

namespace TDDAir.Data.Mappings
{
    public class FlierMap : EntityTypeConfiguration<Flier>
    {
        public FlierMap()
        {
            HasMany(x => x.Flights).WithOptional();
        }
    }
}