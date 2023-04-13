using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopShapes
{
    internal class triangle : Shape
    {
        private int height;
        private int baseTriangle;

        public triangle(int h, int b)
        {
            this.height = h;
            this.baseTriangle = b;
        }
        public override double GetArea()
        {
            return this.height = this.baseTriangle / 2;
        }
    }
}
