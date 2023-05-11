namespace AnimalShelter.Animals
{
    using System;
    using Model;

    public class Horse : IFeedable
    {
        public string Name { get; init; } = string.Empty;

        public byte NumberOfFeedings { get; private set; }

        public string BreedName { get; init; } = string.Empty;

        public void Feed(AvailableFood food)
        {
            switch (food)
            {
                case AvailableFood.Carrot:
                    NumberOfFeedings++;
                    Console.WriteLine("Horse happily ate carrot");
                    break;
                case AvailableFood.Fish:
                    throw new Exception("Horse doesn't eat fish");
                case AvailableFood.Tangerine:
                    throw new Exception("Horse doesn't eat tangerine");
                default:
                    throw new ArgumentOutOfRangeException(nameof(food), food, "Unknown food");
            }
        }
    }
}