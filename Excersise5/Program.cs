
namespace Excersise5;

internal class Program
{
    static void Main(string[] args)
    {
        Point Centr = new(1, 2);
        Point ApexFirst = new(1, 2);
        Point ApexSecond = new(3, 4);
        Point ApexThree = new(3, 5);
        Point ApexFour = new(4, 5);
        Triangles Trio1 = new(ApexFirst, ApexSecond, ApexThree);
        Triangles Trio2 = new(ApexThree, ApexSecond, ApexFour);
        Rectangle Rec1 = new(ApexFirst, ApexSecond);
        Rectangle Rec2 = new(ApexSecond, ApexThree);
        Circle Cir1 = new(Centr, 5);

        GeometricFigure[] figures = {Trio1, Trio2, Rec1, Rec2, Cir1};

        double summa = 0;

        for (int i = 0; i < figures.Length; ++i)
        {
            summa += figures[i].CalculateArea();
        }
        Console.WriteLine(summa);
    }
}