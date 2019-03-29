using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hlp_lab_3_interfaces
{
    class Rectangle : IFigure
    {
        private double a;

        private double b;

        public Rectangle(Point a, Point b)
        {
            this.a = Math.Abs(a.x - b.x);
            this.b = Math.Abs(a.y - b.y);
        }

        public double getPerimeter()
        {
            return (a + b) * 2;
        }

        public double getSquare()
        {
            return a * b;
        }
    }
}
