


Console.WriteLine("Введеите порядковый номер дня недели: 1 - понедельник, 2 - вторник, 3 - среда, 4 - четверг, 5 - пятница, 6 - суббота, 7 - воскресенье");
int numberDay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Этот день выходной? ");

if (numberDay < 6)
{
    Console.Write("Нет");
}
else
{
    Console.Write("Да");
}
