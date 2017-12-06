namespace BeerBrewery.Entities
{
    public interface ITreasury
    {
        decimal GetMoneyAmount ();
        void PutMoney (decimal amount);
        decimal TakeMoney (decimal amount);
    }
}