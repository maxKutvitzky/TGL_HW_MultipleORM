using MultipleORM.Bll.Interfaces.Entities;
using MultipleORM.Bll.Interfaces.IServices;
using MultipleORM.Bll.Mappers;
using MultipleORM.Dal.Interfaces.IRepository;

namespace MultipleORM.Bll.Services;

public class ColorService : IColorService
{
    private readonly IColorRepository _repository;

    public ColorService(IColorRepository repository)
    {
        _repository = repository;
    }
    public int Add(BllColor entity)
    {
        return _repository.Add(entity.ToColor());
    }

    public int Update(BllColor entity)
    {
        return _repository.Update(entity.ToColor());
    }

    public int Delete(BllColor entity)
    {
        return _repository.Delete(entity.ToColor());
    }

    public BllColor GetById(int id)
    {
        return _repository.GetById(id).ToBllColor();
    }

    public IEnumerable<BllColor> GetAll()
    {
        return _repository.GetAll().Select(c => c.ToBllColor());
    }
}