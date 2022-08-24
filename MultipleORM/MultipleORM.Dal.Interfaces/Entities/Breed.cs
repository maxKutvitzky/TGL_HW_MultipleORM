using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultipleORM.Dal.Interfaces.Entities.Base;

namespace MultipleORM.Dal.Interfaces.Entities
{
    public class Breed : EntityBase
    {
        public string Name { get; set; }
    }
}
