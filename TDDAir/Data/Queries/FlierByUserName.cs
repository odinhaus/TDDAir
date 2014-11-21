using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TDDAir.Models;
using Highway.Data;
using TDDAir.Data.Logic;

namespace TDDAir.Data.Queries
{
    public class FlierByUserName : Scalar<Flier>
    {
        public FlierByUserName(string userName, IModelLogic<Flier> logic)
        {
            if (logic == null)
            {
                ContextQuery = DefaultQuery(userName);
            }
            else
            {
                ContextQuery = logic.Apply(DefaultQuery(userName));
            }
        }

        public FlierByUserName(string userName)
        {
            ContextQuery = DefaultQuery(userName);
        }

        Func<IDataContext, Flier> DefaultQuery(string userName)
        {
            return c => c.AsQueryable<Flier>()
                    .SingleOrDefault(f => f.UserName.Equals(userName, StringComparison.InvariantCultureIgnoreCase));
        }

    }
}