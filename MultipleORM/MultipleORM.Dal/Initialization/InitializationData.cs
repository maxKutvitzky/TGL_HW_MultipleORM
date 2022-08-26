
using Bogus;
using MultipleORM.Dal.Interfaces.Entities;

namespace MultipleORM.Dal.Initialization
{
    public static class InitializationData
    {
        public static readonly List<Breed> Breeds = new List<Breed>
        {
            new Breed{Id = 1, Name = "Labrador"},
            new Breed{Id = 2, Name = "Bulldog"},
            new Breed{Id = 3, Name = "Shepherd"},
            new Breed{Id = 4, Name = "Poodle"},
            new Breed{Id = 5, Name = "Beagle"}
        };

        public static readonly List<Color> Colors = new List<Color>
        {
            new Color {Id = 1, Name = "White" },
            new Color {Id = 2, Name = "Black" },
            new Color {Id = 3, Name = "Ginger" },
            new Color {Id = 4, Name = "Brown" },
            new Color {Id = 5, Name = "Gold" }
        };

        public static List<Puppy> GeneratePuppies(int count)
        {
            return new Faker<Puppy>()
                .RuleFor(p => p.Name, f => f.Name.FirstName())
                .RuleFor(p => p.Age, f => f.Random.Int(1, 10))
                .RuleFor(p => p.Weight, f => f.Random.Int(1, 50))
                .RuleFor(p => p.BreedId, f => f.PickRandom(Breeds).Id)
                .RuleFor(p => p.ColorId, f => f.PickRandom(Colors).Id)
                .Generate(count);
        }
    }
}
