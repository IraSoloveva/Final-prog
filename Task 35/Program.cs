


int length = 123;

int[] nums = new int[length];
int i = 0;

while (i < length)
{
    nums[i] = new Random().Next(0, 1000);
    i++;
}

for (i = 0; i < length; i++)
{
    Console.Write(nums[i] + " ");
}

int count = 0;
for (i = 0; i < length; i++)
{
    if (nums[i] >= 10 && nums[i]<=99)
        count = count + 1;
}
Console.WriteLine();
Console.Write("Количество 'элементов массива в диапазоне от 10 до 99': ");
Console.Write(count);
