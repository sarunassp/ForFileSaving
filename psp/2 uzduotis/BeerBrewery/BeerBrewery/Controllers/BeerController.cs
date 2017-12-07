using System;
using BeerBrewery.Services;

namespace BeerBrewery.Controllers
{
    public class BeerController
    {
        private readonly IBeerService m_beerService;

        public BeerController
            (
            IBeerService beerService
            )
        {
            m_beerService = beerService;
        }

        public int BrewBeer
            (
            string name,
            int amount
            )
        {
            throw new NotImplementedException ();
        }

        public int TakeBeer
            (
            string name,
            int amount
            )
        {
            throw new NotImplementedException ();
        }
    }
}