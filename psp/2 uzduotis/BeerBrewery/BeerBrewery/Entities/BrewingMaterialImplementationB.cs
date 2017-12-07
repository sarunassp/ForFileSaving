namespace BeerBrewery.Entities
{
    public class BrewingMaterialImplementationB : IBrewingMaterial
    {
        public decimal Cost { get; set; }
        public string Name { get; set; }
        public string BeerType { get; set; }
    }
}