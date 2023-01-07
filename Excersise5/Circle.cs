using System.Drawing;

namespace Excersise5;

class Circle : GeometricFigure
{
    private Point _centr;
    public Point Centr 
    {
        get 
        { 
            return _centr; 
        }
        set
        {
            if (value != null)
            {
                _centr = value;
            }
        }
    }
    public double Radius { get; set; }
    public Circle(Point centr, double radius)
    {
        Centr = centr;
        Radius = radius;
    }
    public Circle(Point centr, double radius, Color circleColor)
         : base(circleColor)
    {
        Centr = centr;
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * Radius * 2;
    }
}
