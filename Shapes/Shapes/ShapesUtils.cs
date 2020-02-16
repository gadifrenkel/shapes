using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapesUtils
    {
        
        public Shape GetLargestArea(Shape[] myShapes)
        {
            double maxArea = 0;
            Shape maxShape = null;
            foreach (Shape item in myShapes)
            {
                if (item.GetArea() > maxArea)
                {
                    maxArea = item.GetArea();
                    maxShape = item;
                }
            }

            return maxShape;
        }
    }
}
