using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите масть (1-4): ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите достоинство (6-14): ");
        int k = Convert.ToInt32(Console.ReadLine());

        string suit = "";
        string rank = "";

        // Определяем масть
        switch (m)
        {
            case 1: suit = "пик"; break;
            case 2: suit = "треф"; break;
            case 3: suit = "бубен"; break;
            case 4: suit = "червей"; break;
            default: suit = "неизвестной масти"; break;
        }

        // Определяем достоинство
        switch (k)
        {
            case 6: rank = "шестерка"; break;
            case 7: rank = "семерка"; break;
            case 8: rank = "восьмерка"; break;
            case 9: rank = "девятка"; break;
            case 10: rank = "десятка"; break;
            case 11: rank = "валет"; break;
            case 12: rank = "дама"; break;
            case 13: rank = "король"; break;
            case 14: rank = "туз"; break;
            default: rank = "неизвестного достоинства"; break;
        }

        Console.WriteLine($"{rank} {suit}");
    }
}
