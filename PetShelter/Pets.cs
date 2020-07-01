using System;

namespace PetShelter
{
    class Pet {
        public string Name {get; private set;}
        protected int Age;
        protected bool IsAdopted;
        protected bool IsSpayedNeutered;

        public Pet(string nameArg, int ageArg, bool snArg) {
            Name = nameArg;
            Age = ageArg;
            IsSpayedNeutered = snArg;
            IsAdopted = false;
        }

        public virtual void PrintDetails() {
            Console.WriteLine($"Name: {Name}\n\n");
        }
    }

    class Cat : Pet {
        bool IsOutdoor;
        string Colour;   

        public Cat(
            string nameArg, 
            int ageArg, 
            bool snArg, 
            bool isOutdoorArg,
            string colourArg
        ) : base(nameArg, ageArg, snArg) {
            IsOutdoor = isOutdoorArg;
            Colour = colourArg;
        }

        public override void PrintDetails() {
            Console.WriteLine($"Name of cat: {Name}");
            Console.WriteLine($"Colour: {Colour}\n\n");
        }

    }

    class Dog : Pet {
        char Size; // L, M, S
        string DogBreed;

        public Dog(
            string nameArg, 
            int ageArg, 
            bool snArg, 
            char sizeArg, 
            string dogBreedArg
        ) : base(nameArg, ageArg, snArg) {
            if (sizeArg != 'L' && sizeArg != 'M' && sizeArg != 'S') {
                throw new Exception("Invalid dog size");
            }
            Size = sizeArg;
            DogBreed = dogBreedArg;
        }

        public override void PrintDetails() {
            Console.WriteLine($"Name of dog: {Name}");
            Console.WriteLine($"Breed: {DogBreed}\n\n");
        }

    }

    class Mouse : Pet {

        public Mouse(string nameArg, int ageArg, bool snArg): base(nameArg, ageArg, snArg) {
        }
    }

}