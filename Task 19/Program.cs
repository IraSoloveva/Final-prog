Console.WriteLine("Введеите пятизначное число");
int number1 = Convert.ToInt32(Console.ReadLine());

int i1 = number1 / 10000;
int i2 = number1 / 1000 - i1*10;
int d =number1 /100;
int i3 = (number1 - (number1 / 100)*100)/10;
int i4 = number1 % 10;
if (i1 == i4 && i2 == i3)
{
    Console.Write("Число является полиндромом");
}
else
{
    Console.Write("Число НЕ является полиндромом");
}

