using MultipleORM.Bll.Interfaces.Entities;
using MultipleORM.Bll.Interfaces.IServices;
using MultipleORM.Bll.Mappers;
using MultipleORM.Dal.Interfaces.IRepository;

namespace MultipleORM.Bll.Services
{
    public class BreedService : IBreedService
    {
        private IBreedRepository _repository;

        public BreedService(IBreedRepository repository)
        {
            _repository = repository;
        }
        public int Add(BllBreed entity)
        {
            return _repository.Add(entity.ToBreed());
        }

        public int Update(BllBreed entity)
        {
            return _repository.Update(entity.ToBreed());
        }

        public int Delete(BllBreed entity)
        {
            return _repository.Delete(entity.ToBreed());
        }

        public BllBreed GetById(int id)
        {
            return _repository.GetById(id).ToBllBreed();
        }

        public IEnumerable<BllBreed> GetAll()
        {
            return _repository.GetAll().Select(b => b.ToBllBreed());
        }
    }
}
