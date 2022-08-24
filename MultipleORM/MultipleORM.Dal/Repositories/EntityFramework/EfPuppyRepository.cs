using MultipleORM.Dal.Data.EntityFramework;
using MultipleORM.Dal.Interfaces.Entities;
using MultipleORM.Dal.Interfaces.IRepository;
using MultipleORM.Dal.Repositories.EntityFramework.Base;

namespace MultipleORM.Dal.Repositories.EntityFramework
{
    public class EfPuppyRepository : EfBaseRepository<Puppy>, IPuppyRepository
    {
        public EfPuppyRepository(PuppyDbContext context) : base(context)
        {
        }
    }
}
