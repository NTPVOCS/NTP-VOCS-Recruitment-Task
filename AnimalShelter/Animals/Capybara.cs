namespace AnimalShelter.Animals
{
    using System;
    using Model;

    public class Capybara : IFeedable
    {
        public string Name { get; init; } = string.Empty;

        public byte NumberOfFeedings { get; private set; }

        public string CountryOfOrigin { get; init; } = string.Empty;

        public void Feed(AvailableFood food)
        {
            switch (food)
            {
                case AvailableFood.Carrot:
                    throw new Exception("Capybara doesn't eat carrot");
                case AvailableFood.Fish:
                    throw new Exception("Capybara doesn't eat fish");
                case AvailableFood.Tangerine:
                    NumberOfFeedings++;
                    Console.WriteLine("Capybara happily ate tangerine");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(food), food, "Unknown food");
            }
        }
    }
}