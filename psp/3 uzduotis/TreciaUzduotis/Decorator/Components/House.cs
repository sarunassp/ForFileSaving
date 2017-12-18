﻿using System;

namespace Decorator.Components
{
    public class House : AbstractHouse
    {
        public override void a1 ()
        {
        }

        public override void a2 ()
        {
        }

        public override void Draw ()
        {
            // lets imagine it has an implementation
            // and uses size to draw
        }

        public override string GetDescription ()
        {
            return "Simple house";
        }
    }
}