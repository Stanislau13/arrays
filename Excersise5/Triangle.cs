using System.Drawing;

namespace Excersise5;

internal class Triangle : GeometricFigure
{
    public Point FirstApex { get; set; }
    public Point SecondApex { get; set; }
    public Point ThreeApex { get; set; }

    public Triangle(Point firstApex, Point fourApex, Point threeApex, Color color, Border border)
        : base(color, border)
    {
        FirstApex = firstApex;
        SecondApex = fourApex;
        ThreeApex = threeApex;
    }
    public Triangle(Point firstApex, Point fourApex, Point threeApex)
        : this(firstApex, fourApex, threeApex, Color.Empty, null) { }

    public override double CalculateArea()
    {
        double sideA = FirstApex.Distance(ThreeApex);
        double sideB = FirstApex.Distance(SecondApex);
        double sideC = SecondApex.Distance(ThreeApex);
        double p = (sideA + sideB + sideC) / 2;
                
        return Math.Sqrt(p*(p-sideA)*(p-sideB)*(p-sideC));
    }
}
