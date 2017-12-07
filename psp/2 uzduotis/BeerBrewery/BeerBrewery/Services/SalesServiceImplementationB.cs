using BeerBrewery.Entities;
using BeerBrewery.Repositories;

namespace BeerBrewery.Services
{
    public class SalesServiceImplementationB : ISalesService
    {
        private readonly IStorageRepository m_storageRepository;
        private readonly ITreasuryRepository m_treasuryRepository;

        public SalesServiceImplementationB
            (
            IStorageRepository storageRepo,
            ITreasuryRepository treasuryRepo
            )
        {
            m_storageRepository = storageRepo;
            m_treasuryRepository = treasuryRepo;
        }
        
        public int BuyMerchandise<T> (int amount) where T : IBeer, IBrewingMaterial
        {
            throw new System.NotImplementedException ();
        }

        public int OrderMerchandise<T> (int amount) where T : IBeer, IBrewingMaterial
        {
            throw new System.NotImplementedException ();
        }
    }
}