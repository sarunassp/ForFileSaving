namespace BeerBrewery.Entities
{
    public interface IStorage<T> where T : IBeer, IBrewingMaterial
    {
        void Store (T item, int itemAmount);
        T GetItem (int itemAmount);
        int GetItemAmount (T item);
        bool HasItem (T item);
    }
}