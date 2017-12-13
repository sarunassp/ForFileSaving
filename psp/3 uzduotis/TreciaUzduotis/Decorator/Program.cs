using System;
using Decorator.Components;
using Decorator.Decorators;

namespace Decorator
{
    internal class Program
    {
        public static void Main (string[] args)
        {
            var asd = new WindowDecorator (new HouseResizeDecorator (new House (), "resize"), "window") as HouseDecorator;

            asd.Draw ();
            asd = (HouseDecorator) asd.DeleteByRole ("resize");
            
            Console.WriteLine (asd.GetDescription ());
        }
    }
}