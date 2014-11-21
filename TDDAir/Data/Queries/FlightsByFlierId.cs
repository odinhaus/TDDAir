using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TDDAir.Models;
using Highway.Data;
using TDDAir.Data.Logic;

namespace TDDAir.Data.Queries
{
    public class FlightsByFlierId : Query<Flight>
    {
        public FlightsByFlierId(int id, IModelLogic<Flight> logic)
        {
            if (logic == null)
            {
                ContextQuery = DefaultQuery(id);
            }
            else
            {
                ContextQuery = logic.Apply(DefaultQuery(id));
            }
        }

        public FlightsByFlierId(int flierId)
        {
            ContextQuery = c => c.AsQueryable<Flight>()
                .Where(f => f.Flier.Id == flierId);
        }

        Func<IDataContext, IQueryable<Flight>> DefaultQuery(int flierId)
        {
            return c => c.AsQueryable<Flight>()
                    .Where(f => f.Flier.Id.Equals(flierId));
        }
    }
}