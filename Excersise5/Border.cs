using System.Drawing;

namespace Excersise5;
internal class Border
{
    public string Style { get; set; }
    public Color Color { get; set; }

    public Border(string style, Color color)
    {
        Style = style;
        Color = color;
    }
    public override string ToString()
    {
        return $"Border {Color}, Border style is {Style}";
    }
}