using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hlp_lab_3_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFigure> samples = new List<IFigure>();

            samples.Add(new Rectangle(new Point(.9, .2), new Point(4.3, 7.9)));
            samples.Add(new Triangle(new Point(0, 0), new Point(3.2, 0), new Point(1.6, 3)));
            samples.Add(new Circle(new Point(0, 0), 3.7));

            foreach (IFigure sample in samples)
            {
                Print(sample);
            }

            System.Console.In.Read();
        }

        static void Print(IFigure item)
        {
            System.Console.Out.WriteLine("{0}: \tp={1:0.00} \tS={2:0.00}", item.GetType().Name, item.getPerimeter(), item.getSquare());
        }
    }
}
