using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i <= N; i++)
        {
            double term = 1 + i * 0.1;
            sum += Math.Pow(-1, i + 1) * term;
        }

        Console.WriteLine($"{sum:F4}");
    }
}