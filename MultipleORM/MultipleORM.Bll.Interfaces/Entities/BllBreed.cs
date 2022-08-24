using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultipleORM.Bll.Interfaces.Entities.Base;

namespace MultipleORM.Bll.Interfaces.Entities
{
    public class BllBreed : BllBaseEntity
    {
        public string Name { get; set; }
    }
}
