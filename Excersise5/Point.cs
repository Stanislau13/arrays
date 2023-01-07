namespace Excersise5;
internal class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public double Distance(Point second)
    {
        return Math.Sqrt(Math.Pow(second.X - X, 2) + Math.Pow(second.Y - Y, 2));
    }
}
