using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double y;

        if (x > 6.7)
        {
            y = 4 - Math.Exp(4 * x);
        }
        else
        {
            y = Math.Log(3.5 + x);
        }

        Console.WriteLine($"y = {y}");
    }
}