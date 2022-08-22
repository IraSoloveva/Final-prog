
System.Console.WriteLine("Введите желаемый размер массива");

int length = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[length];
int i = 0;

while (i < length)
{
    nums[i] = new Random().Next(0, 10);
    i++;
}

for (i = 0; i < length; i++)
{
    Console.Write(nums[i] + " ");
}
int lnew = 0;
int l = nums.Length;
if (l % 2 == 0)
    lnew = l / 2;
else lnew = l / 2 + 1;

double[] nums1 = new double[lnew];

for (i = 0; i < lnew; i++)
{
    nums1[i] = nums[i] * nums[l - 1];
    l = l - 1;
}
if (lnew % 2 != 0)
{
    nums1[lnew - 1] = Math.Sqrt(nums1[lnew - 1]);
}
Console.WriteLine();
Console.Write("Массив попарных произведений ");

for (i = 0; i < lnew; i++)
{
    Console.Write(nums1[i] + " ");
}
