using Microsoft.EntityFrameworkCore;
using MultipleORM.Dal.Data.EntityFramework;
using MultipleORM.Dal.Interfaces.Entities;
using MultipleORM.Dal.Interfaces.IRepository;
using MultipleORM.Dal.Repositories.EntityFramework.Base;

namespace MultipleORM.Dal.Repositories.EntityFramework
{
    public class EfPuppyRepository : EfBaseRepository<Puppy>
    {
        public EfPuppyRepository(PuppyDbContext context) : base(context)
        {
        }
    }
}
