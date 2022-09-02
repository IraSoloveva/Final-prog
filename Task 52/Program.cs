﻿
System.Console.WriteLine("Введите желаемый размер массива");
System.Console.WriteLine("Количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] nums = new int[m, n];


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        nums[i, j] = new Random().Next(0, 100);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{nums[i, j]}, ");
    }
Console.WriteLine();
}

Console.WriteLine("Средние значения столбцов: ");

double aver = 0;
for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
        aver = aver + nums[i, j];
    }
    Console.Write($"{aver/m}, ");
    aver=0;
}



