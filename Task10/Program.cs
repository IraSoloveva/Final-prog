Console.WriteLine("Введеите трехзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());

int number2 = number1 / 100;
int result = (number1 - number2 * 100) / 10;


Console.Write("Вторая цифра данного трехзначного числа: ");
Console.WriteLine(result);



