

System.Console.WriteLine("Введите несколько чисел, исползуя для их разделения пробел");

string[] nums_strings = Console.ReadLine().Split();

int[] nums = new int[nums_strings.Length];

for (int i = 0; i < nums_strings.Length; i++)
{
    nums[i] = Convert.ToInt32(nums_strings[i]);
}
for (int i = 0; i < nums_strings.Length; i++)
{
    Console.Write(nums[i] + " ");
}