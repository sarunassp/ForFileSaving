using Decorator.Components;

namespace Decorator.Decorators
{
    public class WindowDecorator : HouseDecorator
    {
        public WindowDecorator (AbstractHouse house, string role) : base (house, role)
        {
        }

        public override void Draw ()
        {
            MHouse.Draw ();
            DrawWindow ();
        }

        public void DrawWindow ()
        {
        }

        public override string GetDescription ()
        {
            return MHouse.GetDescription () + ", has windows";
        }
    }
}