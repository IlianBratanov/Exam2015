using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int hight = n * n + 1;
        int empti = d + 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string ('#', i));
            Console.Write("\\");
            Console.Write(new string(' ', d));
            Console.Write('\\');
            Console.Write(new string('.', i));

            Console.Write("/");
            Console.Write(new string(' ', d));
            Console.WriteLine();
        }
    }
}

