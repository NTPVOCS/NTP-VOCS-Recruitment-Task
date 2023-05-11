namespace AnimalShelter.Animals
{
    using System;
    using Model;

    public class Seal : IFeedable
    {
        public string Name { get; init; } = string.Empty;

        public byte NumberOfFeedings { get; private set; }

        public string SubspeciesName { get; init; } = string.Empty;

        public void Feed(AvailableFood food)
        {
            switch (food)
            {
                case AvailableFood.Carrot:
                    throw new Exception("Seal doesn't eat carrot");
                case AvailableFood.Fish:
                    NumberOfFeedings++;
                    Console.WriteLine("Seal happily ate fish");
                    break;
                case AvailableFood.Tangerine:
                    throw new Exception("Seal doesn't eat tangerine");
                default:
                    throw new ArgumentOutOfRangeException(nameof(food), food, "Unknown food");
            }
        }
    }
}