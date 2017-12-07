using BeerBrewery.Entities;
using BeerBrewery.EntityFactories;
using BeerBrewery.Repositories;

namespace BeerBrewery.Services
{
    public class BeerServiceImplementationA : IBeerService
    {
        private readonly IBeerRepository m_beerRepository;
        private readonly IStorageRepository m_storageRepository;
        private readonly IBrewingMaterialRepository m_brewingMaterialRepository;
        private readonly IBeerFactory m_beerFactory;
        
        public BeerServiceImplementationA
            (
            IBeerRepository beerRepo,
            IStorageRepository storageRepo,
            IBrewingMaterialRepository brewingMaterialRepo,
            IBeerFactory beerFactory
            )
        {
            m_beerRepository = beerRepo;
            m_storageRepository = storageRepo;
            m_brewingMaterialRepository = brewingMaterialRepo;
            m_beerFactory = beerFactory;
        }
        
        public void BrewBeer<T> (int amount) where T : IBeer
        {
            throw new System.NotImplementedException ();
        }

        public void StoreBeer<T> (int amount) where T : IBeer
        {
            throw new System.NotImplementedException ();
        }

        public int TakeBeer<T> (int amount) where T : IBeer
        {
            throw new System.NotImplementedException ();
        }
    }
}