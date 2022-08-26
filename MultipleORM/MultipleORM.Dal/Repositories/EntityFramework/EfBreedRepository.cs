using MultipleORM.Dal.Data.EntityFramework;
using MultipleORM.Dal.Interfaces.Entities;
using MultipleORM.Dal.Interfaces.IRepository;
using MultipleORM.Dal.Repositories.EntityFramework.Base;

namespace MultipleORM.Dal.Repositories.EntityFramework;

public class EfBreedRepository : EfBaseRepository<Breed>, IBreedRepository
{
    public EfBreedRepository(PuppyDbContext context) : base(context)
    {
    }
}