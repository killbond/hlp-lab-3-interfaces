using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hlp_lab_3_interfaces
{
    class Circle : IFigure
    {
        private Point center;

        private double r;

        public Circle(Point center, double radius)
        {
            this.center = center;
            this.r = radius;
        }

        public double getPerimeter()
        {
            return 2 * Math.PI * r;
        }

        public double getSquare()
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
