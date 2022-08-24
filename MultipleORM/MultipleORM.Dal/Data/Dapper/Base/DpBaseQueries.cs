using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleORM.Dal.Data.Dapper.Base
{
    public abstract class DpBaseQueries
    {
        public abstract string Add { get; }
        public abstract string Update { get; }
        public abstract string Delete { get; }
        public abstract string GetById { get; }
        public abstract string GetAll { get; }
    }
}
