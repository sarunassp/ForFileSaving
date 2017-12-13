using System;
using ExtensionObjects.Components;
using ExtensionObjects.Extensions;

namespace ExtensionObjects
{
    internal class Program
    {
        public static void Main (string[] args)
        {
            var asd = new House ();
            asd.AddExntesion (new HouseResizeExtensio (asd), "resize");
            asd.AddExntesion (new WindowExtension (asd), "window");

            Console.WriteLine (asd.GetDescription ());
        }
    }
}