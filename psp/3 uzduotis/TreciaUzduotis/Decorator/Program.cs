using System;
using Decorator.Components;
using Decorator.Decorators;

namespace Decorator
{
    internal class Program
    {
        public static void Main (string[] args)
        {
            AbstractHouse asd = new WindowDecorator (new HouseResizeDecorator (new House (), "resize"), "window");

            asd.DeleteByRole ("resize");

            Console.WriteLine (asd.GetDescription ());
        }
    }

    public static class Helpers
    {
        public static void DeleteByRole (this AbstractHouse source, string role)
        {
            var asd = source as HouseDecorator;
            if (null == asd)
                return;

            if (asd.MRole == role)
                source = asd.MHouse;
            
            DeleteByRole (asd.MHouse, role);
        }
    }
}