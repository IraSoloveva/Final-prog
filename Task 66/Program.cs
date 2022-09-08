System.Console.WriteLine("Задайте первое число M: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Задайте второе число N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Сумма натуральных чисел, расположенных между числами M и N: ");


int sum=n;

if (m > n)
{
    for (int i = n; i <= m; i++)
    sum = sum + i + 1;
}
else
{
    for (int i = m; i <= n; i++)
        sum = sum + i-1;
}
System.Console.WriteLine(sum);