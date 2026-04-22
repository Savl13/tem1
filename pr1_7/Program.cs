using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите цифру X: ");
        int X = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите цифру Y: ");
        int Y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Результат:");

        for (int i = B; i >= A; i--)
        {
            if (i % 2 == 0) // чётное
            {
                int lastDigit = Math.Abs(i % 10);

                if (lastDigit == X || lastDigit == Y)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
