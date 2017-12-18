using Decorator.Components;

namespace Decorator.Decorators
{
    public abstract class HouseDecorator : AbstractHouse
    {
        public AbstractHouse MHouse;
        public readonly string MRole;
        
        public HouseDecorator (AbstractHouse house, string role)
        {
            MHouse = house;
            MRole = role;
        }

        protected AbstractHouse GetHouse ()
        {
            if (MHouse.GetType () != typeof(HouseDecorator))
                return MHouse;
            return ((HouseDecorator)MHouse).GetHouse ();
        }
        
        public override void a1 ()
        {
            MHouse.a1 ();
        }
        
        public override void a2 ()
        {
            MHouse.a2 ();
        }

        public abstract override void Draw ();

        public abstract override string GetDescription ();
    }
}