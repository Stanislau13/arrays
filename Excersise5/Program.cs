
namespace Excersise5;

internal class Program
{
    static void Main(string[] args)
    {
        Border FirstBorder = new("solid", System.Drawing.Color.Red);
        Point Centr = new(1, 2);
        Point ApexFirst = new(1, 2);
        Point ApexSecond = new(3, 4);
        Point ApexThree = new(3, 5);
        Point ApexFour = new(4, 5);

        Triangle Trio1 = new(ApexFirst, ApexSecond, ApexThree, System.Drawing.Color.Blue, FirstBorder);
        Triangle Trio2 = new(ApexThree, ApexSecond, ApexFour, System.Drawing.Color.Orange, FirstBorder);
        Rectangle Rec1 = new(ApexFirst, ApexSecond, System.Drawing.Color.White, FirstBorder);
        Rectangle Rec2 = new(ApexSecond, ApexThree, System.Drawing.Color.Green, FirstBorder);
        Circle Cir1 = new(Centr, 5, System.Drawing.Color.Orange, FirstBorder);

        GeometricFigure[] figures = {Trio1, Trio2, Rec1, Rec2, Cir1};

        double summa = 0;

        foreach(GeometricFigure figure in figures)
        {
            summa += figure.CalculateArea();
            Console.WriteLine($"Figure type is {figure}, {figure.Color}, " + 
            $"Border {figure.Border.Color}, Border style is {figure.Border.Style}\n");
        }
        Console.WriteLine(summa);
    }
}