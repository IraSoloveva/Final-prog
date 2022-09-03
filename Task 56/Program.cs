

System.Console.WriteLine("Введите желаемый размер прямоугольного массива");
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
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{nums[i, j]} ");
    }
    Console.WriteLine();
}


int Sum (int[] matr)
{
     int sum = 0;
     for (int i = 0; i < n; i++)
    {
       sum = sum + matr[i];
    }
    return sum;
}

Console.WriteLine();
System.Console.WriteLine("Номер строки с наименьшей суммой значений элементов: ");

int[] result = new int[m];

for (int i = 0; i < m; i++)
{
    int[] nums2 = new int[n];
    for (int j = 0; j < n; j++)
    {
        nums2[j] = nums[i, j];
    } 
    result[i]=Sum(nums2);
}
    int min=0;
for (int i=0; i<m; i++)
    if (result[i]<result[min])
    {
        min=i;
     }   
        
        Console.Write(min+1);
    Console.WriteLine();





