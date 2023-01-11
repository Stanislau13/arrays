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
    public override string ToString()
    {
        return $"Figure type is {GetType()}, color is {Color}";
    }
    public abstract double CalculateArea();
}
