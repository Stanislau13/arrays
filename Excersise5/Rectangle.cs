
namespace Excersise5;

class Rectangle : GeometricFigure
{
    public Point FirstApex { get; set; }
    public Point SecondApex { get; set; }
    public Point ThreeApex { get; set; }
    public Point FourApex { get; set; }

    public Rectangle(Point firstApex, Point fourApex)
    {
        FirstApex = firstApex;
        SecondApex = new Point(firstApex.X, fourApex.Y);
        ThreeApex = new Point(fourApex.X, firstApex.Y);
        FourApex = fourApex;
    }
    public override double CalculateArea()
    {
        return FirstApex.Distance(SecondApex) * FirstApex.Distance(ThreeApex);
    }
}
