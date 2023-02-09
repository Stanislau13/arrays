using System.Security.Cryptography.X509Certificates;

class Programm 
{
    static void Main(string[] args)
    {
        Point[] points = CreateRandomPointsArray(10);

        for (int i = 0; i < points.Length; i++) { 
            Point point = points[i];
            Console.WriteLine($"point {i} (x:y) = {point.X}:{point.Y}");
            
        }

        Console.Write($"Введите номера точек (0-9) между которыми хотите измерить расстояние \nТочка 1: ");
        int indexFirst = Convert.ToInt32(Console.ReadLine());
        Console.Write("Точка 2: ");
        int indexSecond = Convert.ToInt32(Console.ReadLine());
        Distance(points[indexFirst], points[indexSecond]);



    }

    

    static Point[] CreateRandomPointsArray(int length)
    {
        Point[] points = new Point[length];
        Random rand = new Random();
        for (int i = 0; i < length; i++)
        {
            int x = rand.Next(0, length);
            int y = rand.Next(0, length);
            points[i] = new Point(x, y);
        }
        return points;
    }

    static double Distance(Point first, Point second)
    {
        double result = Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2));
        Console.WriteLine($"Distance: {result}");
        return result;
    }
       
}
