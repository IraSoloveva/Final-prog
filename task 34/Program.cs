System.Console.WriteLine("Введите желаемый размер массива");

int length = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[length];
int i = 0;

while (i < length)
{
    nums[i] = new Random().Next(100, 999);
    i++;
}

for (i = 0; i < length; i++)
{
    Console.Write(nums[i] + " ");
}

int count = 0;
for (i = 0; i < length; i++)
{
    if (nums[i] % 2 == 0)
        count = count + 1;
}
Console.WriteLine();
Console.Write("Количество четных чисел в массиве: ");
Console.Write(count);
