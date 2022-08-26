using MultipleORM.Dal.Data.Dapper;
using MultipleORM.Dal.Interfaces.Entities;
using MultipleORM.Dal.Interfaces.IRepository;
using MultipleORM.Dal.Repositories.Dapper.Base;

namespace MultipleORM.Dal.Repositories.Dapper;

public class DpBreedRepository : DpBaseRepository<Breed, DpBreedQueries>, IBreedRepository
{
    public DpBreedRepository(string connString) : base(connString)
    {
    }
}