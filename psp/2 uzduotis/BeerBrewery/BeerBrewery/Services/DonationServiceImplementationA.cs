using BeerBrewery.Entities;
using BeerBrewery.Repositories;

namespace BeerBrewery.Services
{
    public class DonationServiceImplementationA : IDonationService
    {
        private readonly IStorageRepository m_storageRepository;
        private readonly ITreasuryRepository m_treasuryRepository;

        public DonationServiceImplementationA
            (
            IStorageRepository storageRepo,
            ITreasuryRepository treasuryRepo
            )
        {
            m_storageRepository = storageRepo;
            m_treasuryRepository = treasuryRepo;
        }
        
        public void DonateMoney (decimal amount)
        {
            throw new System.NotImplementedException ();
        }

        public void DonateMerchandice<T> () where T : IBeer, IBrewingMaterial
        {
            throw new System.NotImplementedException ();
        }
    }
}