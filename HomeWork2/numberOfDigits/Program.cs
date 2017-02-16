using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberOfDigits
{
    class Program
    {
        // Считает количество цифр в числе
        static int numbOfDig(int n)
        {
            int sum = 0;
            do
            {
                sum++;
                n = n / 10;
            } while (n!=0);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество цифр в числе = {numbOfDig(n)}");            
            Console.ReadKey();
        }
    }
}
