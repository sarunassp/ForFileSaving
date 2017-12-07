using BeerBrewery.Entities;
using BeerBrewery.Repositories;

namespace BeerBrewery.Services
{
    public class BeerServiceImplementationB : IBeerService
    {
        private readonly IBeerRepository m_beerRepository;
        private readonly IStorageRepository m_storageRepository;
        private readonly IBrewingMaterialRepository m_brewingMaterialRepository;
        
        public BeerServiceImplementationB
            (
            IBeerRepository beerRepo,
            IStorageRepository storageRepo,
            IBrewingMaterialRepository brewingMaterialRepo
            )
        {
            m_beerRepository = beerRepo;
            m_storageRepository = storageRepo;
            m_brewingMaterialRepository = brewingMaterialRepo;
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