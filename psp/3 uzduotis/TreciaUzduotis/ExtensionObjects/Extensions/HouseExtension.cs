using ExtensionObjects.Components;

namespace ExtensionObjects.Extensions
{
    public abstract class HouseExtension
    {
        protected AbstractHouse m_house;

        public HouseExtension (AbstractHouse house)
        {
            m_house = house;
        }
        
        public abstract void Draw ();
        public abstract string GetDescription ();
    }
}