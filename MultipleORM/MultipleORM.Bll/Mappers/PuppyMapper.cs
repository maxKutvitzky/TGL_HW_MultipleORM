using MultipleORM.Bll.Interfaces.Entities;
using MultipleORM.Dal.Interfaces.Entities;

namespace MultipleORM.Bll.Mappers
{
    public static class PuppyMapper
    {
        public static BllPuppy ToBllPuppy(this Puppy puppy)
        {
            return new BllPuppy
            {
                Id = puppy.Id,
                Name = puppy.Name,
                Age = puppy.Age,
                Breed = new BllBreed()
                {
                    Id = puppy.Breed.Id,
                    Name = puppy.Breed.Name
                },
                BreedId = puppy.BreedId,
                Color = new BllColor()
                {
                    Id = puppy.Color.Id,
                    Name = puppy.Color.Name
                },
                ColorId = puppy.ColorId,
                Weight = puppy.Weight
            };
        }

        public static Puppy ToPuppy(this BllPuppy bllPuppy)
        {
            return new Puppy()
            {
                Id = bllPuppy.Id,
                Name = bllPuppy.Name,
                Age = bllPuppy.Age,
                Breed = new Breed()
                {
                    Id = bllPuppy.Breed.Id,
                    Name = bllPuppy.Breed.Name
                },
                BreedId = bllPuppy.BreedId,
                Color = new Color()
                {
                    Id = bllPuppy.Color.Id,
                    Name = bllPuppy.Color.Name
                },
                ColorId = bllPuppy.ColorId,
                Weight = bllPuppy.Weight
            };
        }
    }
}
