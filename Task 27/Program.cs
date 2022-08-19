
Console.WriteLine("Введеите  число");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int d = number;

while (d > 10)
{
    int i2 = d % 10;
    sum = sum + i2;
    d = d / 10;
}
Console.WriteLine(d);
sum = sum + d;
Console.WriteLine("Сумма цифр введенного числа равна:");
Console.WriteLine(sum);



