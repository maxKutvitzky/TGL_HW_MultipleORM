using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultipleORM.Dal.Data.Dapper.Base;

namespace MultipleORM.Dal.Data.Dapper
{
    public class DpColorQueries : DpBaseQueries
    {
        public override string Add { get; } =
            @"INSERT INTO Colors (Name)
            VALUES (@Name)";

        public override string Update { get; } =
            @"UPDATE Colors SET 
            Name = @Name
            WHERE Id = @Id";

        public override string Delete { get; } =
            @"DELETE FROM Colors 
            WHERE Id = @Id";

        public override string GetById { get; } =
            @"SELECT FROM Colors 
            WHERE Id = @Id";

        public override string GetAll { get; } =
            @"SELECT * FROM Colors";
    }
}
}
