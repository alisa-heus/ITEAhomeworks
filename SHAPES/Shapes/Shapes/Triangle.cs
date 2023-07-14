using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle
    {
        public double CalculateArea(double triangleBase, double triangleHeight)
        {
            double area = 0.5 * (triangleBase * triangleHeight);
            return area;
        }
    }
}
