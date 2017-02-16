using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goodNumber
{
    class Program
    {
        // Подсчитывает сумму цифр числа
        static int sum(int n)
        {
            int s = 0;
            do
            {
                s = s + n % 10;
                n = n / 10;
            } while (n != 0);
            return s;
        }
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            int x = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                if (i%sum(i) == 0)
                {
                    x++;
                }
            }

            DateTime finish = DateTime.Now;
            Console.WriteLine($"Количество чисел, удовлетворяющих требованиям = {x}, время выполнения программы {finish-start}");
            Console.ReadKey();
        }
    }
}
