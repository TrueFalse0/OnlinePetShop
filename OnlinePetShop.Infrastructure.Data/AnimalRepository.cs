using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using OnlinePetShop.Domain.Core;
using OnlinePetShop.Domain.Interfaces;

namespace OnlinePetShop.Infrastructure.Data
{
    public class AnimalRepository : IAnimalRepository
    {
        private OrderContext dataBase;

        public AnimalRepository()
        {
            this.dataBase = new OrderContext();
        }

        public IEnumerable<Animal> GetAnimalList()
        {
            return dataBase.Animals.ToList();
        }

        public Animal GetAnimalId(int id)
        {
            return dataBase.Animals.Find(id);
        }

        public void CreateAnimal(Animal animal)
        {
            dataBase.Animals.Add(animal);
        }

        public void UpdateAnimal(Animal animal)
        {
            dataBase.Entry(animal).State = EntityState.Modified;
        }

        public void DeleteAnimal(int id)
        {
            Animal animal = dataBase.Animals.Find(id);
            if (animal != null)
                dataBase.Animals.Remove(animal);
        }

        public void SaveAnimal()
        {
            dataBase.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dataBase.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
