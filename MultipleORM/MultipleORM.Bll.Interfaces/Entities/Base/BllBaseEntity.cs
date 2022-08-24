using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleORM.Bll.Interfaces.Entities.Base
{
    public abstract class BllBaseEntity
    {
        public Guid Id { get; set; }
    }
}
