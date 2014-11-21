using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Highway.Data;
using TDDAir.Data.Mappings;

namespace TDDAir.Data
{
    public class TDDAirMappings : IMappingConfiguration
    {
        public void ConfigureModelBuilder(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FlierMap());
            modelBuilder.Configurations.Add(new FlightMap());
        }
    }
}