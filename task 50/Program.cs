

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);

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

System.Console.WriteLine("Введите позицию элемента массива, указав номер строки и номер столбца через пробел");

string[] nums_strings = Console.ReadLine().Split();

int[] position = new int[2];

for (int i = 0; i < 2; i++)
{
    position[i] = Convert.ToInt32(nums_strings[i]);
}
if (true)
{
   Console.Write("Значение элемента с указанной позицией: ");
    Console.Write(nums[position[0]-1, position[1]-1]);
}
else
{
Console.Write("В массиве элекмента с такой позицией нет");
}