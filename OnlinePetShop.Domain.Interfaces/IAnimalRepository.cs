using OnlinePetShop.Domain.Core;
using System;
using System.Collections.Generic;

namespace OnlinePetShop.Domain.Interfaces
{
    public interface IAnimalRepository : IDisposable
    {
        IEnumerable<Animal> GetAnimalList();
        Animal GetAnimalId(int id);
        void CreateAnimal(Animal animal);
        void UpdateAnimal(Animal animal);
        void DeleteAnimal(int id);
        void SaveAnimal();
    }
}