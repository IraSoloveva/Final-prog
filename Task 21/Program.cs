using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введеите Координаты первой точки: ");
        Console.WriteLine("Координата X1: ");
        int x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Координата X2: ");
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Координата X3: ");
        int z1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введеите Координаты второй точки: ");
        Console.WriteLine("Координата y1: ");
        int x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Координата y2: ");
        int y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Координата y3: ");
        int z2 = Convert.ToInt32(Console.ReadLine());

       double  d1= (x2 - x1)*(x2 - x1); 
       double  d2= (y2 - y1)*(y2 - y1);
       double  d3= (z2 - z1)*(z2 - z1);
        double d = d1+d2+d3;

       double  r = Math.Sqrt(d);
        Console.WriteLine("Расстояние между двумя точками: ");
        Console.WriteLine(r);
    }
}