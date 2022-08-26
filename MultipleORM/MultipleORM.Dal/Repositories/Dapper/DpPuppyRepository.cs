using MultipleORM.Dal.Data.Dapper;
using MultipleORM.Dal.Interfaces.Entities;
using MultipleORM.Dal.Interfaces.IRepository;
using MultipleORM.Dal.Repositories.Dapper.Base;
using Dapper;
using Microsoft.Data.SqlClient;

namespace MultipleORM.Dal.Repositories.Dapper
{
    public class DpPuppyRepository : DpBaseRepository<Puppy,DpPuppyQueries>, IPuppyRepository
    {
        public DpPuppyRepository(string connString) : base(connString)
        {
        }
        public override Puppy GetById(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                return conn.Query<Puppy, Color, Breed, Puppy>(_queries.GetById, ((puppy, color, breed) =>
                {
                    puppy.Color = color;
                    puppy.Breed = breed;
                    return puppy;
                })).FirstOrDefault(p => p.Id == id);
            }
        }

        public virtual IEnumerable<Puppy> GetAll()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                return conn.Query<Puppy, Color, Breed, Puppy>(_queries.GetById, ((puppy, color, breed) =>
                {
                    puppy.Color = color;
                    puppy.Breed = breed;
                    return puppy;
                }));
            }
        }
    }
}
