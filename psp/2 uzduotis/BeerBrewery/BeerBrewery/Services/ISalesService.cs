using BeerBrewery.Entities;

namespace BeerBrewery.Services
{
    public interface ISalesService<T> where T: IBeer, IBrewingMaterial
    {
        (T item, int amount) BuyMerchandise (string itemName, int amount);
        (T item, int amount) OrderMerchandise (string itemName, int amount);
    }
}