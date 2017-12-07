using BeerBrewery.Services;

namespace BeerBrewery.Controllers
{
    public class SalesController
    {
        private readonly ISalesService m_salesService;

        public SalesController
            (
            ISalesService salesService
            )
        {
            m_salesService = salesService;
        }
    }
}