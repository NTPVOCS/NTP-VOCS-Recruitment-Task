namespace AnimalShelterTests
{
    using System;
    using AnimalShelter.Animals;
    using AnimalShelter.Services;
    using FluentAssertions;
    using NUnit.Framework;

    public class FeedingServiceTests
    {
        private IAnimalFeedingService _animalFeedingService;

        private Capybara _capybara;

        private Horse _horse;

        private Seal _seal;

        [SetUp]
        public void Setup()
        {
            _capybara = new Capybara
                        {
                            Name = "Mandaryniara",
                            CountryOfOrigin = "Argentina"
                        };

            _horse = new Horse
                     {
                         Name = "Płotka",
                         BreedName = "Arabian"
                     };

            _seal = new Seal
                    {
                        Name = "Joel",
                        SubspeciesName = "Concolor"
                    };

            //TODO: Initialize _animalFeedingService field with your implementation
        }

        [Test]
        public void FeedOnceTest()
        {
            Action action = () => _animalFeedingService.FeedAnimals();

            action.Should().NotThrow();
            _capybara.NumberOfFeedings.Should().Be(1);
            _horse.NumberOfFeedings.Should().Be(1);
            _seal.NumberOfFeedings.Should().Be(1);
        }
    }
}