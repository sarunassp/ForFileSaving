namespace BeerBrewery.Entities
{
    public interface ITreasury
    {
        decimal Capacity { get; set; }
        decimal CostPerTransaction { get; set; }
        string Name { get; set; }
        string Currency { get; set; }
        decimal TakeMoney (decimal amount);
        void PutMoney (decimal amount);
    }
}