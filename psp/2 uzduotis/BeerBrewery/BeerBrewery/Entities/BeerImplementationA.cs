using System;

namespace BeerBrewery.Entities
{
    public class BeerImplementationA : IBeer
    {
        public decimal Price { get; set; }
        public decimal AlcoholicContent { get; set; }
        public string Type { get; set; }
        public TimeSpan TimeToBrew { get; set; }
        public string Name { get; set; }
    }
}