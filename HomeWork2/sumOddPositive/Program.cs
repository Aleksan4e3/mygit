using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOddPositive
{
    class Program
    {
        // Определение четности (нечетное = true)
        static bool isOdd(int n)
        {
            return n % 2 != 0;           
        }
        
        // Положительное или нет
        static bool isPositive(int n)
        {
            if (n>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
                
        static void Main(string[] args)
        {
            int s = 0;
            while (true)            
            {
                Console.WriteLine("Введите число");
                int x = Convert.ToInt32(Console.ReadLine());
                if (isOdd(x) && isPositive(x))
                {
                    s = s + x;
                }
                if (x == 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Сумма положительных нечетных чисел {s}");
            Console.ReadKey();           
        }
    }
}
