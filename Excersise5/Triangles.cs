
using System;

namespace Excersise5
{
    internal class Triangles : GeometricFigure
    {
        public Point FirstApex { get; set; }
        public Point SecondApex { get; set; }
        public Point ThreeApex { get; set; }

        public Triangles(int x1, int x2, int x3, int y1, int y2)
        {
            FirstApex = new Point(x1, y1);
            SecondApex = new Point(x2, y2);
            ThreeApex = new Point(x3, y1);
        }

        public override double CalculateArea()
        {
            double c = Point.Distance(ThreeApex, FirstApex);

            double h = SecondApex.Y - FirstApex.Y;

            return c * h / 2;
        }
    }
}
