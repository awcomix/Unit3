using System;
using PetShelter;

namespace Unit3
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat1 = new Cat("Aya", 1, true, false, "white");
            var dog1 = new Dog("Jaina", 1, true, 'M',"Blue Heeler");
            var mouse1 = new Mouse("Ron", 1, false);

            var shelter = new Shelter(10);

            shelter.ReceiveNewPet(mouse1);
            shelter.ReceiveNewPet(cat1);
            shelter.ReceiveNewPet(dog1);

            shelter.ListAllPets();

        }
    }
   
}
