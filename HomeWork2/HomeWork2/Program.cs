using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxNumber 
{
    using static Console;
    class Program
    {
        // Находит наибольшее из 3-ех чисел
        static int maxNumber(int a, int b, int c)
        {
            if (a !=b && b!=c && c !=a)
            {
                if (a > b && a > c)
                {
                    return a;
                }
                else if (b > c && b > a)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
            if (a == b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            if (a == c)
            {
                if (a > b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
            if (c == b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            return a;
        }    
        static void Main(string[] args)
        {
            WriteLine("Введите три числа");
            int a = Convert.ToInt32(ReadLine());
            int b = Convert.ToInt32(ReadLine());
            int c = Convert.ToInt32(ReadLine());

            WriteLine($"Наибольшее число {maxNumber(a, b, c)}");
            ReadKey();
        }
    }
}
