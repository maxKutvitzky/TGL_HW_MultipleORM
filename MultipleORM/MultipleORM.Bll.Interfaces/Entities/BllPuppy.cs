using MultipleORM.Bll.Interfaces.Entities.Base;

namespace MultipleORM.Bll.Interfaces.Entities;

public class BllPuppy : BllBaseEntity
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public BllColor Color { get; set; }
    public int ColorId { get; set; }
    public BllBreed Breed { get; set; }
    public int BreedId { get; set; }
}