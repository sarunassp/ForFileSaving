namespace BeerBrewery.Entities
{
    public interface IStorage
    {
        int Capacity { get; set; }
        string Name { get; set; }
        decimal CostToStore { get; set; }
        void Store<T> (int itemAmount) where T: IBeer, IBrewingMaterial;
        void GetItem<T> (int itemAmount) where T: IBeer, IBrewingMaterial;
    }
}