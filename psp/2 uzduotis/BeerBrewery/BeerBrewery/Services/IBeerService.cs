using BeerBrewery.Entities;

namespace BeerBrewery.Services
{
    public interface IBeerService
    {
        void BrewBeer<T> (int amount) where T : IBeer;
        void StoreBeer<T> (int amount) where T: IBeer;
        int TakeBeer<T> (int amount) where T: IBeer;
    }
}