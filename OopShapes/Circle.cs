﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopShapes
{
    internal class Circle : Shape
    {
        private int radius;

        public Circle(int r)
        {
            this.radius = r;
        }

        public override double GetArea()
        {
            return 3.14 * radius * radius;
        }
    }
}
