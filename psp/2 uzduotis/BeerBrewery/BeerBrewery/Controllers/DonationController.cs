using BeerBrewery.Services;

namespace BeerBrewery.Controllers
{
    public class DonationController
    {
        private readonly IDonationService m_donationService;

        public DonationController 
            (
            IDonationService donationService
            )
        {
            m_donationService = donationService;
        }
    }
}