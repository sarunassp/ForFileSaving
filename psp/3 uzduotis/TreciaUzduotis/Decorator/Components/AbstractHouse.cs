namespace Decorator.Components
{
    public abstract class AbstractHouse
    {
        protected internal int MHeight = 50;
        protected internal int MWidth = 50;

        public abstract void Draw ();
        public abstract string GetDescription ();
    }
}