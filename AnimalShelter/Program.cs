namespace AnimalShelter
{
    using Animals;
    using Model;
    using Services;

    internal class Program
    {
        private static IAnimalFeedingService _animalFeedingService;
        
        public static void Main(string[] args)
        {
            var capybara = new Capybara
                           {
                               Name = "Mandaryniara",
                               CountryOfOrigin = "Argentina"
                           };

            var horse = new Horse
                        {
                            Name = "Płotka",
                            BreedName = "Arabian"
                        };

            var seal = new Seal
                       {
                           Name = "Joel",
                           SubspeciesName = "Concolor"
                       };

            //The part we want to share with external provider
            //After implementation replace that code block with the one below
            capybara.Feed(AvailableFood.Tangerine);
            horse.Feed(AvailableFood.Carrot);
            seal.Feed(AvailableFood.Fish);
            
            //TODO: Initialize _animalFeedingService field with your implementation
            //_animalFeedingService.FeedAnimals();
        }
    }
}