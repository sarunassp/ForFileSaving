namespace BeerBrewery.Entities
{
    public interface IBrewingMaterial
    {
        decimal Cost { get; set; }
        string Name { get; set; }
        string BeerType { get; set; }
    }
}