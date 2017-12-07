using System.Collections.Generic;
using BeerBrewery.Entities;

namespace BeerBrewery.Repositories
{
    public class StorageRepoImplementationA : IStorageRepository
    {
        public IList<IStorage> GetAll ()
        {
            throw new System.NotImplementedException ();
        }

        public IStorage Get (string name)
        {
            throw new System.NotImplementedException ();
        }

        public void Add (IStorage beer)
        {
            throw new System.NotImplementedException ();
        }

        public void Delete (string name)
        {
            throw new System.NotImplementedException ();
        }
    }
}