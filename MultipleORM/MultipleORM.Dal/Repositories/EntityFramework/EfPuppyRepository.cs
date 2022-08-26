using Microsoft.EntityFrameworkCore;
using MultipleORM.Dal.Data.EntityFramework;
using MultipleORM.Dal.Interfaces.Entities;
using MultipleORM.Dal.Interfaces.IRepository;
using MultipleORM.Dal.Repositories.EntityFramework.Base;

namespace MultipleORM.Dal.Repositories.EntityFramework;

public class EfPuppyRepository : EfBaseRepository<Puppy>, IPuppyRepository
{
    public EfPuppyRepository(PuppyDbContext context) : base(context)
    {
    }

    public override Puppy GetById(int id)
    {
        return _dbSet.Where(p => p.Id == id)
            .Include(p => p.Color)
            .Include(p => p.Breed)
            .FirstOrDefault();
    }

    public override IEnumerable<Puppy> GetAll()
    {
        return _dbSet.Include(p => p.Color)
            .Include(p => p.Breed);
    }
}