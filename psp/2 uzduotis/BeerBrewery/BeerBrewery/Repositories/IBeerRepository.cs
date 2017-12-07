using System.Collections.Generic;
using BeerBrewery.Entities;

namespace BeerBrewery.Repositories
{
    public interface IBeerRepository
    {
        IList<IBeer> GetAll ();
        IBeer Get (string name);
        void Add (IBeer beer);
        void Delete (string name);
    }
}