using ExtensionObjects.Components;

namespace ExtensionObjects.Extensions
{
    public class HouseResizeExtensio : HouseExtension
    {
        public HouseResizeExtensio (AbstractHouse house) : base (house)
        {
        }

        public override void Draw ()
        {
            ResizeHouse ();
            // draw resized or something
        }

        public void ResizeHouse ()
        {
            MHouse.Height = 20;
            MHouse.Width = 20;
        }

        public override string GetDescription ()
        {
            return ", is resized";
        }
    }
}