
System.Console.WriteLine("Задайте размерность матриц m: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] nums1 = new int[m, m];
int[,] nums2 = new int[m, m];

Console.WriteLine("Первая матрица: ");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        nums1[i, j] = new Random().Next(0, 10);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{nums1[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Вторая матрица: ");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        nums2[i, j] = new Random().Next(0, 10);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{nums2[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Результирующая матрица");
int[,] result = new int[m, m];



for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        result[i, j] = nums1[i, j] * nums2[i, j];
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{result[i, j]} ");
    }
    Console.WriteLine();
}







