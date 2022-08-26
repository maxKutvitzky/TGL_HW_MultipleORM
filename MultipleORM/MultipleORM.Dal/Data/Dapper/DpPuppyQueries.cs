using MultipleORM.Dal.Data.Dapper.Base;

namespace MultipleORM.Dal.Data.Dapper
{
    public class DpPuppyQueries : DpBaseQueries
    {
        public override string Add { get; } = 
            @"INSERT INTO Puppies (Name, Age, Weight, ColorId, BreedId)
            VALUES (@Name, @Age, @Weight, @ColorId, @BreedId)";

        public override string Update { get; } = 
            @"UPDATE Puppies SET 
            Name = @Name,
            Age = @Age, 
            Weight = @Weight, 
            ColorId = @ColorId, 
            BreedId = @BreedId
            WHERE Id = @Id";

        public override string Delete { get; } =
            @"DELETE FROM Puppies 
            WHERE Id = @Id";
        //Filter in query execution
        public override string GetById { get; } =
            @"SELECT * FROM Puppies p
            JOIN Colors c ON c.Id = p.ColorId
            JOIN Breeds b ON b.Id = p.BreedId";

        public override string GetAll { get; } =
            @"SELECT * FROM Puppies p
            JOIN Colors c ON c.Id = p.ColorId
            JOIN Breeds b ON b.Id = p.BreedId";
    }
}
