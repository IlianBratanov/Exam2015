using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int countRow = 0;
        long oddPosition = 1;
        long oddPositionUpgrade = 1;
        long oddPosition1 = 1;


        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }


            if (countRow % 2 != 0)
            {
               
                foreach (char symbol in input)
                {
                    oddPosition = 1;
                    oddPositionUpgrade = 1;
                    int num = symbol - '0';
                    oddPosition *= num;
                }
                oddPositionUpgrade *= oddPosition;
                oddPosition1 *= oddPositionUpgrade;
                
            }

            
            countRow++;
        }
        Console.WriteLine(oddPosition1);
    }
}

