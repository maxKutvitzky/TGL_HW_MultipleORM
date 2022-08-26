using MultipleORM.Bll.Interfaces.Entities;
using MultipleORM.Dal.Interfaces.Entities;

namespace MultipleORM.Bll.Mappers;

public static class PuppyMapper
{
    public static BllPuppy ToBllPuppy(this Puppy puppy)
    {
        if (puppy == null) return null;
        BllPuppy bllPuppy = new BllPuppy
        {
            Id = puppy.Id,
            Name = puppy.Name,
            Age = puppy.Age,
            BreedId = puppy.BreedId,
            ColorId = puppy.ColorId,
            Weight = puppy.Weight
        };
        if (puppy.Color != null)
            bllPuppy.Color = new BllColor
            {
                Id = puppy.Color.Id,
                Name = puppy.Color.Name
            };
        if (puppy.Breed != null)
            bllPuppy.Breed = new BllBreed
            {
                Id = puppy.Breed.Id,
                Name = puppy.Breed.Name
            };
        return bllPuppy;
    }

    public static Puppy ToPuppy(this BllPuppy bllPuppy)
    {
        if (bllPuppy == null) return null;
        Puppy newPuppy = new Puppy
        {
            Id = bllPuppy.Id,
            Name = bllPuppy.Name,
            Age = bllPuppy.Age,
            BreedId = bllPuppy.BreedId,
            ColorId = bllPuppy.ColorId,
            Weight = bllPuppy.Weight
        };
        if (bllPuppy.Color != null)
            newPuppy.Color = new Color
            {
                Id = bllPuppy.Color.Id,
                Name = bllPuppy.Color.Name
            };
        if (bllPuppy.Breed != null)
            newPuppy.Breed = new Breed
            {
                Id = bllPuppy.Breed.Id,
                Name = bllPuppy.Breed.Name
            };
        return newPuppy;
    }
}