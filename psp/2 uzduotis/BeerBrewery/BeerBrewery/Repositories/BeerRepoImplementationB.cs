using System.Collections.Generic;
using BeerBrewery.Entities;

namespace BeerBrewery.Repositories
{
    public class BeerRepoImplementationB : IBeerRepository
    {
        public IList<IBeer> GetAll ()
        {
            throw new System.NotImplementedException ();
        }

        public IBeer Get (string name)
        {
            throw new System.NotImplementedException ();
        }

        public void Add (IBeer beer)
        {
            throw new System.NotImplementedException ();
        }

        public void Delete (string name)
        {
            throw new System.NotImplementedException ();
        }
    }
}