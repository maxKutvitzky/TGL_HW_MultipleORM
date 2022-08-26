using MultipleORM.Dal.Data.Dapper.Base;

namespace MultipleORM.Dal.Data.Dapper
{
    public class DpBreedQueries : DpBaseQueries
    {
        public override string Add { get; } =
            @"INSERT INTO Breeds (Name)
            VALUES (@Name)";

        public override string Update { get; } =
            @"UPDATE Breeds SET 
            Name = @Name
            WHERE Id = @Id";

        public override string Delete { get; } =
            @"DELETE FROM Breeds 
            WHERE Id = @Id";

        public override string GetById { get; } =
            @"SELECT * FROM Breeds 
            WHERE Id = @Id";

        public override string GetAll { get; } =
            @"SELECT * FROM Breeds";
    }
}
