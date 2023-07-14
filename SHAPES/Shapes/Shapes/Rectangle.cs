using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle
    {
        public double CalculatePerimeter(double width, double length)
        {
            return 2 * (width + length);
        }
        public double CalculateArea(double width, double length) 
        {
            return width * length;
        }
    }
}
