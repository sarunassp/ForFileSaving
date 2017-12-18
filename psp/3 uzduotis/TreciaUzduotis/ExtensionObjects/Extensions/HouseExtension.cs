using ExtensionObjects.Components;

namespace ExtensionObjects.Extensions
{
    public abstract class HouseExtension
    {
        protected AbstractHouse MHouse;

        public HouseExtension (AbstractHouse house)
        {
            MHouse = house;
        }
        
        public abstract void Draw ();
        public abstract string GetDescription ();
    }
}