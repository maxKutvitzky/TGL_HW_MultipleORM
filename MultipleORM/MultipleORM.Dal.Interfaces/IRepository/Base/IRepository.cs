using MultipleORM.Dal.Interfaces.Entities.Base;

namespace MultipleORM.Dal.Interfaces.IRepository.Base;

public interface IRepository<T> where T : EntityBase
{
    int Add(T entity);
    int Update(T entity);
    int Delete(T entity);
    T GetById(int id);
    IEnumerable<T> GetAll();
}