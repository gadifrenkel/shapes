using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rechtangel : Shape
    {

        public double length { get; set; }
        public double width { get; set; }
        public override double GetArea()
        {
            return length*width;
        }

        public override double GetPerimeter()
        {
            return 2 * (length + width); 
        }
    }
}
