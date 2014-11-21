using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Highway.Data;

namespace TDDAir.Data.Logic
{
    public interface IModelLogic<T> where T:class
    {
        Func<IDataContext, T> Apply(Func<IDataContext, T> scalarQuery);
        Func<IDataContext, IQueryable<T>> Apply(Func<IDataContext, IQueryable<T>> enumerableQuery);
    }
}