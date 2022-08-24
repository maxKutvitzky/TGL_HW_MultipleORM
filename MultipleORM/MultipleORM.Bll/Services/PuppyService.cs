using MultipleORM.Bll.Interfaces.Entities;
using MultipleORM.Bll.Interfaces.IServices;
using MultipleORM.Bll.Mappers;
using MultipleORM.Dal.Interfaces.IRepository;

namespace MultipleORM.Bll.Services
{
    public class PuppyService : IPuppyService
    {
        private readonly IPuppyRepository _repository;

        public PuppyService(IPuppyRepository repository)
        {
            _repository = repository;
        }
        public int Add(BllPuppy entity)
        {
            return _repository.Add(entity.ToPuppy());
        }

        public int Update(BllPuppy entity)
        {
            return _repository.Update(entity.ToPuppy());
        }

        public int Delete(BllPuppy entity)
        {
            return _repository.Update(entity.ToPuppy());
        }

        public BllPuppy GetById(Guid id)
        {
            return _repository.GetById(id).ToBllPuppy();
        }

        public IEnumerable<BllPuppy> GetAll()
        {
            return _repository.GetAll().Select(p => p.ToBllPuppy());
        }
    }
}
