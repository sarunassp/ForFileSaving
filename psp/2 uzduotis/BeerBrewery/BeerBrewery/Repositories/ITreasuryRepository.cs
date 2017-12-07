using System.Collections.Generic;
using BeerBrewery.Entities;

namespace BeerBrewery.Repositories
{
    public interface ITreasuryRepository
    {
        IList<ITreasury> GetAll ();
        ITreasury Get (string name);
        void Add (ITreasury beer);
        void Delete (string name);
    }
}