using MultipleORM.Dal.Interfaces.Entities.Base;

namespace MultipleORM.Dal.Interfaces.Entities
{
    public class Puppy : EntityBase
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public Color Color { get; set; }
        public int ColorId { get; set; }
        public Breed Breed { get; set; }
        public int BreedId { get; set; }
    }
}
