using Decorator.Components;

namespace Decorator.Decorators
{
    public class HouseResizeDecorator : HouseDecorator
    {
        public HouseResizeDecorator (AbstractHouse house, string role) : base (house, role)
        {
        }

        public override void Draw ()
        {
            ResizeHouse ();
            m_house.Draw ();
        }

        public void ResizeHouse ()
        {
            var concreteHouse = GetHouse ();
            concreteHouse.MHeight = 20;
            concreteHouse.MWidth = 20;
        }

        public override string GetDescription ()
        {
            return m_house.GetDescription () + ", is resized";
        }
    }
}