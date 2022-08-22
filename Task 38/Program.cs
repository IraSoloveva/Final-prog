
System.Console.WriteLine("Введите желаемый размер массива");

int length = Convert.ToInt32(Console.ReadLine());

double[] nums = new double[length];
int i = 0;

while (i < length)
{
    nums[i] = new Random().Next(0, 100);
    i++;
}

for (i = 0; i < length; i++)
{
    Console.Write(nums[i] + " ");
}

double min = nums[0];
double max = nums[0];
for (i = 0; i < length; i++)
{
    if (nums[i] > max)
        max = nums[i];
        
        if (nums[i] < min)
        min = nums[i];
}
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементами массива: ");
Console.Write(max-min);
