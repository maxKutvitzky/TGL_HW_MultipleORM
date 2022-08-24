using System;
using Dapper;
using Microsoft.Data.SqlClient;
using MultipleORM.Dal.Data.Dapper;
using MultipleORM.Dal.Data.Dapper.Base;
using MultipleORM.Dal.Interfaces.Entities.Base;
using MultipleORM.Dal.Interfaces.IRepository.Base;

namespace MultipleORM.Dal.Repositories.Dapper.Base
{
    public abstract class DpBaseRepository<T,Q> : IRepository<T> where T : EntityBase where Q : DpBaseQueries, new()
    {
        protected readonly string connectionString;
        
        private readonly DpBaseQueries _queries = new Q();
        protected DpBaseRepository(string connString)
        {
            connectionString = connString;
        }

        public int Add(T entity)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                return conn.Execute(_queries.Add, entity);
            }
        }

        public int Update(T entity)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                return conn.Execute(_queries.Update, entity);
            }
        }

        public int Delete(T entity)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                return conn.Execute(_queries.Delete, entity);
            }
        }

        public T GetById(Guid id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                return conn.QuerySingleOrDefault<T>(_queries.GetById, new { id });
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                return conn.Query<T>(_queries.GetAll);
            }
        }
    }
}
