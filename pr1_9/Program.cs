using System;

class Program
{
    static void Main()
    {
        double A = Math.PI / 4;
        double B = 4 / Math.PI;
        int M = 20;

        double H = (B - A) / M;

        Console.WriteLine(" i\t   x\t\tF(x)");

        for (int i = 0; i <= M; i++)
        {
            double x = A + i * H;
            double F = Math.Cos(1 / x);

            Console.WriteLine($"{i}\t{x:F5}\t{F:F5}");
        }
    }
}
