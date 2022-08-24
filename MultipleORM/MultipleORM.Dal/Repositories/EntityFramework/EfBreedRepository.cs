using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MultipleORM.Dal.Data.EntityFramework;
using MultipleORM.Dal.Interfaces.Entities;
using MultipleORM.Dal.Interfaces.IRepository;
using MultipleORM.Dal.Repositories.EntityFramework.Base;

namespace MultipleORM.Dal.Repositories.EntityFramework
{
    public class EfBreedRepository : EfBaseRepository<Breed>
    {
        public EfBreedRepository(PuppyDbContext context) : base(context)
        {
        }
    }
}
