using MultipleORM.Dal.Data.Dapper;
using MultipleORM.Dal.Data.Dapper.Base;
using MultipleORM.Dal.Interfaces.Entities;
using MultipleORM.Dal.Repositories.Dapper.Base;

namespace MultipleORM.Dal.Repositories.Dapper
{
    public class DpColorRepository: DpBaseRepository<Color>
    {
        private readonly DpBaseQueries _queries = new DpColorQueries();
        public DpColorRepository(string connString) : base(connString)
        {
        }

        public override int Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public override int Update(Color entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public override Color GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Color> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
