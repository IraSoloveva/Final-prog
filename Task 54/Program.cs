
int m = new Random().Next(1, 5);
int n = new Random().Next(1, 5);

int[,] nums = new int[m, n];

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

int[] Sort(int[] matr)
{
    for (int i = 0; i < n - 1; i++)
    {
        int max = i;
        for (int j = i + 1; j < n; j++)
        {
            if (matr[j] > matr[max])
            {
                max = j;
            }
        }
        int temp = matr[i];
        matr[i] = matr[max];
        matr[max] = temp;
    }
    return matr;
}

Console.WriteLine();
System.Console.WriteLine("Упорядоченный по убыванию значений элементов по строкам массив:");



for (int i = 0; i < m; i++)
{
    int[] nums2 = new int[n];

    for (int j = 0; j < n; j++)
    {
        nums2[j] = nums[i, j];
    }

    Sort(nums2);

    for (int j = 0; j < n; j++)
    {
        Console.Write($"{nums2[j]} ");
    }
    Console.WriteLine();
}










