using BeerBrewery.Entities;

namespace BeerBrewery.Services
{
    public interface IDonationService
    {
        void DonateMoney (decimal amount);
        void DonateMerchandice<T> () where T : IBeer, IBrewingMaterial;
    }
}