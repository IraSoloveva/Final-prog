
System.Console.WriteLine("Введите несколько чисел, исползуя для их разделения пробел");

string[] nums_strings = Console.ReadLine().Split();

string[] nums = new string[nums_strings.Length];

for (int i = 0; i < nums_strings.Length; i++)
{
    nums[i] = Convert.ToString(nums_strings[i]);
}

for (int i = 0; i < nums_strings.Length; i++)
{
   if (nums[i].Length <=3)
    Console.Write(nums[i] + " ");
}

