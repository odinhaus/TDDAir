using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Highway.Data;
using Highway.Data.EventManagement.Interfaces;

namespace TDDAir.Data
{
    public class TDDAir : IDomain
    {
        public TDDAir(string connectionString)
        {
            ConnectionString = connectionString;
            Mappings = new TDDAirMappings();
            Events = new List<IInterceptor>();
        }

        public string ConnectionString { get; private set; }
        public IMappingConfiguration Mappings { get; private set; }
        public IContextConfiguration Context { get; private set; }
        public List<IInterceptor> Events { get; private set; }
    }
}