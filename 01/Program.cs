using System;

class Program
{
    static void Main()
    {
        // problem ako i dvete sa nula
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal aritmeticMeans = (a + b + c) / 3;
        decimal bigest = 0;
        decimal smailest = 0;

        //a
       // if (a == 0)
        //{
            if (a >= b && a >= c)
            {
                if (b >= c)
                {
                    smailest = c;
                }
                else
                {
                    smailest = b;
                }
                bigest = a;


            }
       // }
       // else
       // {


            if (a > b && a > c)
            {
                if (b > c)
                {
                    smailest = c;
                }
                else
                {
                    smailest = b;
                }
                bigest = a;


            }
      //  }
        //b
       // if (b == 0)
       // {
            if (b >= a && b >= c)
            {
                if (a >= c)
                {
                    smailest = c;
                }
                else
                {
                    smailest = a;
                }
                bigest = b;
            }
       // }
       // else
       // {
            if (b > a && b > c)
            {
                if (a > c)
                {
                    smailest = c;
                }
                else
                {
                    smailest = a;
                }
                bigest = b;
            }
       // }
        //c
        //if (c == 0)
       // {
            if (c >= a && c >= b)
            {
                if (a >= b)
                {
                    smailest = b;
                }
                else
                {
                    smailest = a;
                }
                bigest = c;

            }
       // }
       // else
       // {
            if (c > a && c > b)
            {
                if (a > b)
                {
                    smailest = b;
                }
                else
                {
                    smailest = a;
                }
                bigest = c;

            }
        //}
        Console.WriteLine(bigest);
        Console.WriteLine(smailest);
        Console.WriteLine("{0:F2}", aritmeticMeans);

    }
}

