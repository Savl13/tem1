using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сторону a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите сторону b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите сторону c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine("Треугольник равносторонний");
        }
        else
        {
            Console.WriteLine("Треугольник не равносторонний");
        }
    }
}
