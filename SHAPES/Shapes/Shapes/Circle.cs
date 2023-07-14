using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle
    {
        public double CalculateArea(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
