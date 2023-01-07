using System.Drawing;

namespace Excersise5;

internal class Triangles : GeometricFigure
{
    public Point FirstApex { get; set; }
    public Point SecondApex { get; set; }
    public Point ThreeApex { get; set; }

    // public Triangles(int x1, int x2, int x3, int y1, int y2)
    public Triangles(Point firstApex, Point fourApex, Point threeApex)
    {
        FirstApex = firstApex;
        SecondApex = fourApex;
        ThreeApex = threeApex;
    }

    public override double CalculateArea()
    {
        //  double h = SecondApex.Y - FirstApex.Y;
        double sideA = FirstApex.Distance(ThreeApex);
        double sideB = FirstApex.Distance(SecondApex);
        double sideC = SecondApex.Distance(ThreeApex);
        double p = (sideA + sideB + sideC) / 2;
                
        return Math.Sqrt(p*(p-sideA)*(p-sideB)*(p-sideC));
    }
}
