System.Console.WriteLine("Введите желаемый размер массива");

int length = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[length];
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

int sum = 0;
int i2=1;
while (i2  < length)
{
        sum = sum + nums[i2];
        i2=i2+2;
}
Console.WriteLine();
Console.Write("Сумма элементов массива стоящих не нечетных позициях: ");
Console.Write(sum);

