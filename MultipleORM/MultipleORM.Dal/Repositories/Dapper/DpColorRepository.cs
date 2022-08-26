using MultipleORM.Dal.Data.Dapper;
using MultipleORM.Dal.Interfaces.Entities;
using MultipleORM.Dal.Interfaces.IRepository;
using MultipleORM.Dal.Repositories.Dapper.Base;

namespace MultipleORM.Dal.Repositories.Dapper;

public class DpColorRepository : DpBaseRepository<Color, DpColorQueries>, IColorRepository
{
    public DpColorRepository(string connString) : base(connString)
    {
    }
}