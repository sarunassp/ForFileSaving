using BeerBrewery.Entities;

namespace BeerBrewery.EntityFactories
{
    public interface IBeerFactory
    {
        IBeer CreateBeer ();
        IBrewingMaterial CreateBrewingMaterial ();
    }
}