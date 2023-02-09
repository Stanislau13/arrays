
namespace Excersise5
{
    class Rectangle : GeometricFigure
    {
        public Point FirstApex { get; set; }
        public Point SecondApex { get; set; }
        public Point ThreeApex { get; set; }
        public Point FourApex { get; set; }

        public Rectangle(int x1, int x2, int y1, int y2)
        {
            FirstApex = new Point(x1, y1);
            SecondApex = new Point(x1, y2);
            ThreeApex = new Point(x2, y1);
            FourApex = new Point(x2, y2);
        }

        public override double CalculateArea()
        {
            double a = Point.Distance(FirstApex, SecondApex);

            double b = Point.Distance(FirstApex, ThreeApex);

            return a * b;
        }
    }
}
