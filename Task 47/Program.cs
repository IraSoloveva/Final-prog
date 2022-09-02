
System.Console.WriteLine("Введите желаемый размер массива");
System.Console.WriteLine("Количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());


double[,] nums = new double[m, n];


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        nums[i, j] = new Random().Next(0, 100);
    }
}
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{nums[i, j]} ");
    }
    Console.WriteLine();
}


