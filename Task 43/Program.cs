
System.Console.WriteLine("Уравление прямой описывается уравнением: y=k1*x+b1");
System.Console.WriteLine("Введите значение k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение^ b1");
int b1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Уравление прямой описывается уравнением: y=k2*x+b2");
System.Console.WriteLine("Введите значение k2:");
int k2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение^ b2");
int b2 = Convert.ToInt32(Console.ReadLine());

float d1 = b2-b1;

float d2 = k1-k2;

float x = d1 / d2;

float y = k1*x+b1;


Console.Write("Координаты точки пересечения двух прямых: (");

Console.Write(x + ",");
Console.WriteLine(y + ")");