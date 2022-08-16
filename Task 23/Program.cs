
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введеите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int i = 1;
        while (i <= number)
        {
            Console.Write(Math.Pow(i, 3));
            Console.Write(",");
            i = i+1;
        }
    }
}