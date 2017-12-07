using System.Collections.Generic;
using BeerBrewery.Entities;

namespace BeerBrewery.Repositories
{
    public interface IStorageRepository
    {
        IList<IStorage> GetAll (); 
        IStorage Get (string name);
        void Add (IStorage beer);
        void Delete (string name);
    }
}