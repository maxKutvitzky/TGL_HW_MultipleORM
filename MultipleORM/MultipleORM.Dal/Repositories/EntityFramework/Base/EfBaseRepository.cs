using Microsoft.EntityFrameworkCore;
using MultipleORM.Dal.Data.EntityFramework;
using MultipleORM.Dal.Interfaces.Entities.Base;
using MultipleORM.Dal.Interfaces.IRepository.Base;

namespace MultipleORM.Dal.Repositories.EntityFramework.Base;

public abstract class EfBaseRepository<T> : IRepository<T> where T : EntityBase
{
    protected readonly PuppyDbContext _dbContext;
    protected readonly DbSet<T> _dbSet;
    protected EfBaseRepository(PuppyDbContext context)
    {
        _dbContext = context;
        _dbSet = _dbContext.Set<T>();
    }
    public int Add(T entity)
    {
        _dbSet.Add(entity);
        return _dbContext.SaveChanges();
    }

    public int Update(T entity)
    {
        _dbSet.Update(entity);
        return _dbContext.SaveChanges();
    }

    public int Delete(T entity)
    {
        _dbSet.Remove(entity);
        return _dbContext.SaveChanges();
    }

    public virtual T GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public virtual IEnumerable<T> GetAll()
    {
        return _dbSet;
    }
}