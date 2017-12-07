using System.Collections.Generic;
using BeerBrewery.Entities;

namespace BeerBrewery.Repositories
{
    public class TreasuryRepoImplementationA : ITreasuryRepository
    {
        public IList<ITreasury> GetAll ()
        {
            throw new System.NotImplementedException ();
        }

        public ITreasury Get (string name)
        {
            throw new System.NotImplementedException ();
        }

        public void Add (ITreasury beer)
        {
            throw new System.NotImplementedException ();
        }

        public void Delete (string name)
        {
            throw new System.NotImplementedException ();
        }
    }
}