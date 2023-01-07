using System.Drawing;

namespace Excersise5;

abstract class GeometricFigure
{
    public Color Color { get; set; }
    public Border Border { get; set; }

    public GeometricFigure()
    {
    }

    public GeometricFigure(Color color, Border border)
    {
       Color = color;
       Border = border;
    }

    public abstract double CalculateArea();
}
