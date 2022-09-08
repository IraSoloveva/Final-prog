
System.Console.WriteLine("Введите первое число m: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число n: ");
int n = Convert.ToInt32(Console.ReadLine());

static int Akkerman (int m, int n)
{
    if (m == 0)
    {
        return n +1;
    }
    else
if (m != 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

System.Console.WriteLine("Функция Аккермана для числе m и n равна: ");
System.Console.WriteLine(Akkerman(m,n));