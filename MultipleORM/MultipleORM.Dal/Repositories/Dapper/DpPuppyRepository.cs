using Dapper;
using Microsoft.Data.SqlClient;
using MultipleORM.Dal.Data.Dapper;
using MultipleORM.Dal.Data.Dapper.Base;
using MultipleORM.Dal.Interfaces.Entities;
using MultipleORM.Dal.Repositories.Dapper.Base;

namespace MultipleORM.Dal.Repositories.Dapper
{
    public class DpPuppyRepository : DpBaseRepository<Puppy,DpPuppyQueries>
    {
        public DpPuppyRepository(string connString) : base(connString)
        {
        }
    }
}
