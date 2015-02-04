using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        
        int salt = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        long countSymbol = 0;
        
        decimal leter = 0;
        decimal digit = 0;
        decimal inputSym = 0;

        
        
        foreach (char symbol in text)
        {

            if (symbol == '@')
            {
                return;
            }
            //numb
            else if (symbol == '0' || symbol == '1' || symbol == '2' || symbol == '3' || symbol == '4' || symbol == '5' || symbol == '6' || symbol == '7' || symbol == '8' || symbol == '9')
            {
                if (countSymbol % 2 == 0)
                {
                    digit = symbol + salt + 500;
                    digit = digit / 100;
                    Console.WriteLine("{0:F2}", digit);
                }
                else if (countSymbol % 2 != 0)
                {
                    digit = symbol + salt + 500;
                    digit = digit * 100;
                    Console.WriteLine(digit);
                }
                //letter
            }
            else if (symbol == 'A' || symbol == 'B' || symbol == 'C' || symbol == 'D' || symbol == 'E' || symbol == 'F' || symbol == 'G'
                || symbol == 'H' || symbol == 'I' || symbol == 'G' || symbol == 'K' || symbol == 'L' || symbol == 'M' || symbol == 'N'
                || symbol == 'O' || symbol == 'P' || symbol == 'Q' || symbol == 'R' || symbol == 'S' || symbol == 'T' || symbol == 'U'
                || symbol == 'V' || symbol == 'W' || symbol == 'X' || symbol == 'Y' || symbol == 'Z' || symbol == 'a' || symbol == 'b' || symbol == 'c' || symbol == 'd' || symbol == 'e' || symbol == 'f' || symbol == 'g'
                || symbol == 'h' || symbol == 'i' || symbol == 'g' || symbol == 'k' || symbol == 'l' || symbol == 'm' || symbol == 'n'
                || symbol == 'o' || symbol == 'p' || symbol == 'q' || symbol == 'r' || symbol == 's' || symbol == 't' || symbol == 'u'
                || symbol == 'v' || symbol == 'w' || symbol == 'x' || symbol == 'y' || symbol == 'z')
            {
                if (countSymbol % 2 == 0)
                {
                    leter = symbol * salt + 1000;
                    leter = leter / 100;
                    Console.WriteLine("{0:F2}", leter);
                }
                else if (countSymbol % 2 != 0)
                {
                    leter = symbol * salt + 1000;
                    leter = leter * 100;
                    Console.WriteLine(leter);
                }

            }
            else
            {
                if (countSymbol % 2 == 0)
                {
                    inputSym = symbol - salt;
                    inputSym = inputSym / 100;
                    Console.WriteLine("{0:F2}", inputSym);

                }
                else if (countSymbol % 2 != 0)
                {
                    inputSym = symbol - salt;
                    inputSym = inputSym * 100;
                    Console.WriteLine(inputSym);
                }

            }
            ++countSymbol;
        }
    }
}

