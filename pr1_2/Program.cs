using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int a = n / 100;
        int b = (n / 10) % 10;
        int c = n % 10;

        bool result = (a < b && b < c) || (a > b && b > c);

        Console.WriteLine(result);
    }
}
