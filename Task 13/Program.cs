
Console.WriteLine("Введеите число");
int number1 = Convert.ToInt32(Console.ReadLine());

int d =100;
int c = number1 / d;
int pr = number1;

if (c == 0)
{
    Console.Write("Такого числа нет");
}
else
{
    while (pr > 1000)
    {
     pr = pr /10;   
    }
    int t = pr/10;
    int h = pr / 100;
    Console.Write("Третья цифра данного числа: ");
    Console.WriteLine(pr - t*10 - h/100);
}
