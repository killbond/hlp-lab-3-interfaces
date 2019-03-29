using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hlp_lab_3_interfaces
{
    class Point
    {
        public double x;

        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetDistance(Point subject)
        {
            return Math.Sqrt(Math.Pow(this.x - subject.x, 2) + Math.Pow(this.y - subject.y, 2));
        }
    }
}
