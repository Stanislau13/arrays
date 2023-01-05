
namespace Excersise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point Centr = new(1, 2);
            Triangles Trio1 = new(1, 2, 3, 4, 5);
            Triangles Trio2 = new(1, 3, 5, 1, 3);
            Rectangle Rec1 = new(1, 2, 3, 4);
            Rectangle Rec2 = new(3, 4, 3, 5);
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
}