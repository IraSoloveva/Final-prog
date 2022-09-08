System.Console.WriteLine("Задайте первое число M: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Задайте второе число N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Ряд натуральных чисел, расположенных между числами M и N: ");

if (m > n)
{
    for (int i = n; i <= m; i++)
        System.Console.WriteLine(i);
}
else
{
    for (int i = m; i <= n; i++)
        System.Console.WriteLine(i);
}



