

int[] numbers = new int[2];

Console.WriteLine("Введите 2 числа");
Console.WriteLine("Число А:");
numbers[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число B: ");
numbers[1] = Convert.ToInt32(Console.ReadLine());

    int p = 1;
    for (int i = 1; i <= numbers[1]; i++)
    {
        p = p * numbers[0];
    }
  Console.WriteLine(p);  



