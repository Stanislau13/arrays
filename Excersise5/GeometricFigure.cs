using System.Drawing;

namespace Excersise5;

abstract class GeometricFigure
{
    public Color FigureColor { get; set; }
    // public Color LineColor { get; set; }

    public GeometricFigure()
    {
    }

    public GeometricFigure(Color figureColor)
    {
       FigureColor = figureColor;
    }

    public abstract double CalculateArea();
}
