namespace Decorator.Components
{
    public abstract class AbstractHouse
    {
        protected internal int MHeight = 50;
        protected internal int MWidth = 50;

        public abstract void a1 ();
        public abstract void a2 ();
        public abstract void Draw ();
        public abstract string GetDescription ();
    }
}