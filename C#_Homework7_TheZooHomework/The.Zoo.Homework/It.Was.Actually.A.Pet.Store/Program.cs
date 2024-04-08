using Zoo.Domain.Generics;
using Zoo.Domain.Models;

PetStore<Dog> dogStore = new PetStore<Dog>()
{
    ListOfPets = new List<Dog>()
    {
        new Dog("Boshko", "Dzukela", 6, true, "Toast from the nearby store"),
        new Dog("Ada", "Weiner", 9, false, "Wet dog food")
    }
};

PetStore<Cat> catStore = new PetStore<Cat>()
{
    ListOfPets = new List<Cat>()
    {
        new Cat("Lusi", "White Persian", 3, true, 5),
        new Cat("Greys", "Gray Persian", 1, false, 9),
    }
};

PetStore<Fish> fishStore = new PetStore<Fish>()
{
    ListOfPets = new List<Fish>()
    {
        new Fish("Bubbles", "Bony-eared assfish (this is a real type btw)", 3, "from 1171-4415 meters large", "Gray"),
        new Fish("Shub-Niggurath of the depths", "Clown fish", 2, "about 2 thumbs", "Orange with white stripes"),
    }
};


dogStore.BuyPet("Boshko");
