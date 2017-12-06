using System;
using System.Threading;

namespace BeerBrewery.Entities
{
    public interface IBeer
    {
        decimal Price { get; set; }
        decimal AlcoholicContent { get; set; }
        string Type { get; set; }
        TimeSpan TimeToBrew { get; set; }
        string Name { get; set; }
    }
}