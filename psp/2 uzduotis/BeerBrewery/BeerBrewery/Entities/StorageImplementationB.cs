namespace BeerBrewery.Entities
{
    public class StorageImplementationB : IStorage
    {
        public int Capacity { get; set; }
        public string Name { get; set; }
        public decimal CostToStore { get; set; }
        
        public void Store<T> (int itemAmount) where T : IBeer, IBrewingMaterial
        {
            throw new System.NotImplementedException ();
        }

        public void GetItem<T> (int itemAmount) where T : IBeer, IBrewingMaterial
        {
            throw new System.NotImplementedException ();
        }
    }
}