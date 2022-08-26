using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using MultipleORM.Dal.Data.EntityFramework;
using MultipleORM.Dal.Interfaces.Initialization;

namespace MultipleORM.Dal.Initialization
{
    public class EfDbInitializer : IDbInitialization
    {
        private readonly int _puppiesCount;
        private readonly PuppyDbContext _dbContext;

        public EfDbInitializer(int puppiesCount, PuppyDbContext context)
        {
            _puppiesCount = puppiesCount;
            _dbContext = context;
        }

        private void SeedData()
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    _dbContext.BulkInsert(InitializationData.Breeds);
                    _dbContext.BulkInsert(InitializationData.Colors);
                    _dbContext.BulkInsert(InitializationData.GeneratePuppies(_puppiesCount));
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return;
                }
                transaction.Commit();
            }
        }

        private void SeedDataOptional()
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    if(!_dbContext.Breeds.Any())
                        _dbContext.BulkInsert(InitializationData.Breeds);
                    if (!_dbContext.Colors.Any())
                        _dbContext.BulkInsert(InitializationData.Colors);
                    if (!_dbContext.Puppies.Any())
                        _dbContext.BulkInsert(InitializationData.GeneratePuppies(_puppiesCount));
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
                transaction.Commit();
            }
        }
        public void Initialize()
        {
            _dbContext.Database.Migrate();
            SeedDataOptional();
        }

        public void InitializeWithRecreation()
        {
            _dbContext.Database.EnsureDeleted();
            _dbContext.Database.Migrate();
            SeedData();
        }
    }
}
