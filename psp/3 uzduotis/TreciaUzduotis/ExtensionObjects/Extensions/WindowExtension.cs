using System;
using ExtensionObjects.Components;

namespace ExtensionObjects.Extensions
{
    public class WindowExtension : HouseExtension
    {
        private int m_height = 5;
        private int m_width = 5;
        
        public override void Draw ()
        {
            // draw some kind of window here
        }

        public Tuple<int, int> GetWindowSize ()
        {
            return Tuple.Create (m_height, m_width);
        }

        public override string GetDescription ()
        {
            return ", with windows";
        }

        public WindowExtension (AbstractHouse house) : base (house)
        {
        }
    }
}