using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MultipleORM.Dal.Interfaces.Entities;

namespace MultipleORM.Dal.Data.EntityFramework
{
    public class PuppyDbContext : DbContext
    {
        public PuppyDbContext (DbContextOptions<PuppyDbContext> options) : base(options){}

        #region DbSets

        public DbSet<Puppy> Puppies { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Breed> Breeds { get; set; }

        #endregion
    }
}
