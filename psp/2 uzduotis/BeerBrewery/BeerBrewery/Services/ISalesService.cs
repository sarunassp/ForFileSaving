using System;
using BeerBrewery.Entities;

namespace BeerBrewery.Services
{
    public interface ISalesService
    {
        int BuyMerchandise<T> (int amount) where T: IBeer, IBrewingMaterial;
        int OrderMerchandise<T> (int amount) where T: IBeer, IBrewingMaterial;
    }
}