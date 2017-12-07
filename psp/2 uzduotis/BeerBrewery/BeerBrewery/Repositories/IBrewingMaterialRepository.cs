using System.Collections.Generic;
using BeerBrewery.Entities;

namespace BeerBrewery.Repositories
{
    public interface IBrewingMaterialRepository
    {
        IList<IBrewingMaterial> GetAll ();
        IBrewingMaterial Get (string name);
        void Add (IBrewingMaterial beer);
        void Delete (string name);
    }
}