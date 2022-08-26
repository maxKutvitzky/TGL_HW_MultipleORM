using MultipleORM.Bll.Interfaces.Entities.Base;
namespace MultipleORM.Bll.Interfaces.IServices.Base;

public interface IService<T> where T : BllBaseEntity
{
    int Add(T entity);
    int Update(T entity);
    int Delete(T entity);
    T GetById(int id);
    IEnumerable<T> GetAll();
}