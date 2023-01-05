
namespace Excersise5
{
    class Circle : GeometricFigure
    {
        public Point Centr { get; set; }
        public double Radius { get; set; }


        public Circle(Point centr, double radius)
        {
            Centr = centr;
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * 2;
           
        }
    }
}
