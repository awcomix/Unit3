using System;
using System.Collections.Generic;

namespace PetShelter
{
    class Shelter {
        List<Pet> _petList;
        int _numAdoptions;
        int _capacity;

        public Shelter(int capacityArg) {
            _petList = new List<Pet>();
            _numAdoptions = 0;
            _capacity = capacityArg;
        }

        public void ReceiveNewPet(Pet newPet) {
            if (_petList.Count <= _capacity) {
                _petList.Add(newPet);
                Console.WriteLine("Received a new pet!");
            } else {
                throw new Exception("Sorry, shelter is full.");
            }
        }

        public void ListAllPets() {
            foreach (var pet in _petList) {
                pet.PrintDetails();
            }
        }

        public void AdoptAPet(string name) {
            // Adopt
        }

    }
}