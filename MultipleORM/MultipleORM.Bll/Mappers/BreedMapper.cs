using MultipleORM.Bll.Interfaces.Entities;
using MultipleORM.Dal.Interfaces.Entities;

namespace MultipleORM.Bll.Mappers;

public static class BreedMapper
{
    public static BllBreed ToBllBreed(this Breed breed)
    {
        return new BllBreed()
        {
            Id = breed.Id,
            Name = breed.Name,
        };
    }

    public static Breed ToBreed(this BllBreed bllBreed)
    {
        return new Breed()
        {
            Id = bllBreed.Id,
            Name = bllBreed.Name
        };
    }
}