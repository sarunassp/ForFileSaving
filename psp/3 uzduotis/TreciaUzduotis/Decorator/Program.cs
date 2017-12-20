using System;
using System.Diagnostics;
using Decorator.Components;
using Decorator.Decorators;

namespace Decorator
{
    internal class Program
    {
        public static void Main (string[] args)
        {
            AbstractHouse asd = new WindowDecorator (new HouseResizeDecorator (new House (), "resize"), "window");
            
            Helpers.DeleteByRole (ref asd, "resize");

            Console.WriteLine (asd.GetDescription ());
        }
    }

    public static class Helpers
    {
        public static void DeleteByRole (ref AbstractHouse source, string role)
        {
            var asd = source as HouseDecorator;
            if (null == asd)
                return;

            if (asd.MRole == role)
                source = asd.MHouse;
            else
                Helpers.DeleteByRole (ref asd.MHouse, role);
        }

        public static HouseDecorator GetByRole (AbstractHouse source, string role)
        {
            var asd = source as HouseDecorator;
            if (null == asd)
                throw new ArgumentOutOfRangeException (role);

            if (role == asd.MRole)
                return asd;
            return GetByRole (asd.MHouse, role);
        }
    }
}