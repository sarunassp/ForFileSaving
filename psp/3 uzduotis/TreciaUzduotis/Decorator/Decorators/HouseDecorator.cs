using Decorator.Components;

namespace Decorator.Decorators
{
    public abstract class HouseDecorator : AbstractHouse
    {
        protected AbstractHouse m_house;
        protected readonly string m_role;
        
        public HouseDecorator (AbstractHouse house, string role)
        {
            m_house = house;
            m_role = role;
        }

        protected AbstractHouse GetHouse ()
        {
            if (m_house.GetType () == typeof(House))
                return m_house;
            return ((HouseDecorator)m_house).GetHouse ();
        }
        
        public AbstractHouse GetByRole (string role)
        {
            if (role == m_role)
                return this;
            if (m_house.GetType () == typeof(HouseDecorator))
                return ((HouseDecorator)m_house).GetByRole (role);
            return null;
        }

        public AbstractHouse DeleteByRole (string role)
        {
            if (role != m_role)
                m_house = ((HouseDecorator)m_house).DeleteByRole (role);
            
            return role == m_role ? m_house : this;
        }
        public abstract override void Draw ();

        public abstract override string GetDescription ();
    }
}