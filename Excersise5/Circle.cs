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

    public Circle(Point centr, double radius, Color color, Border border)
         : base(color, border)
    {
        Centr = centr;
        Radius = radius;
    }
    public Circle(Point centr, double radius)
        : this(centr, radius, Color.Empty, null) { }
    public override double CalculateArea()
    {
        return Math.PI * Radius * 2;
    }
}
