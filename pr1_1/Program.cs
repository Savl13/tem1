using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine($"Сумма: {a + b}");
        Console.WriteLine($"Разность: {a - b}");
        Console.WriteLine($"Произведение: {a * b}");

        if (b != 0)
            Console.WriteLine($"Частное: {a / b}");
        else
            Console.WriteLine("Деление на ноль невозможно");
    }
}