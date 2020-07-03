using System;
using System.Collections.Generic;
using System.Linq;

namespace PetShelter
{
    interface IPetStorage {
        int NumberOfPets();

        void Save(Pet pet);

        void Remove(Pet pet);

        List<Pet> GetAll(); 
    }


    class PetStorageList : IPetStorage {
        List<Pet> _petList;

        public PetStorageList() {
            _petList = new List<Pet>();
        }

        public int NumberOfPets() {
            return _petList.Count;
        }

        public void Save(Pet pet) {
            _petList.Add(pet);
        }

        public void Remove(Pet pet) {
            var petIndex = _petList.FindIndex(x => x.Name == pet.Name);
            _petList.RemoveAt(petIndex);
        }

        public List<Pet> GetAll() {
            return _petList;
        }
    }
}