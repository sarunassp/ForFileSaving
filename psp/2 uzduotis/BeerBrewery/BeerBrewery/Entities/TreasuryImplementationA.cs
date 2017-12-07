namespace BeerBrewery.Entities
{
    public class TreasuryImplementationA : ITreasury
    {
        public decimal Capacity { get; set; }
        public decimal CostPerTransaction { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public decimal TakeMoney (decimal amount)
        {
            throw new System.NotImplementedException ();
        }

        public void PutMoney (decimal amount)
        {
            throw new System.NotImplementedException ();
        }
    }
}