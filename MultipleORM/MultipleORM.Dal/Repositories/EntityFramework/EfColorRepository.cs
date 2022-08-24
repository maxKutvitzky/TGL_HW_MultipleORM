using MultipleORM.Dal.Data.EntityFramework;
using MultipleORM.Dal.Interfaces.Entities;
using MultipleORM.Dal.Interfaces.IRepository;
using MultipleORM.Dal.Repositories.EntityFramework.Base;

namespace MultipleORM.Dal.Repositories.EntityFramework
{
    public class EfColorRepository : EfBaseRepository<Color>, IColorRepository
    {
        public EfColorRepository(PuppyDbContext context) : base(context)
        {
        }
    }
}
