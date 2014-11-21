using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDDAir.Data.Logic
{
    public abstract class BaseLogic<T> : IModelLogic<T> where T : class
    {
        public Func<Highway.Data.IDataContext, T> Apply(Func<Highway.Data.IDataContext, T> scalarQuery)
        {
            return c =>
            {
                var t = scalarQuery(c);
                return Apply(t);
            };
        }

        public Func<Highway.Data.IDataContext, IQueryable<T>> Apply(Func<Highway.Data.IDataContext, IQueryable<T>> enumerableQuery)
        {
            return c =>
            {
                List<T> ts = new List<T>();
                foreach (var t in enumerableQuery(c))
                    ts.Add(Apply(t));
                return ts.AsQueryable<T>();
            };
        }

        protected abstract T Apply(T model);
    }
}