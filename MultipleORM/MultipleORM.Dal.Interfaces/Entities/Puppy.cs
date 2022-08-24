using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultipleORM.Dal.Interfaces.Entities.Base;

namespace MultipleORM.Dal.Interfaces.Entities
{
    public class Puppy : EntityBase
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public Color Color { get; set; }
        public Guid ColorId { get; set; }
        public Breed Breed { get; set; }
        public Guid BreedId { get; set; }
    }
}
