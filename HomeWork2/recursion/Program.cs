using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    using static Console;
    class Program
    {
        // Рекурсивный счетчик с использованием StringBuilder
        static StringBuilder sb(int a, int b)
        {
            StringBuilder sb = new StringBuilder();
            
            if (a == b)
            {
                return sb.Append(Convert.ToString(a));
            }
            else
            {
                return sb.Append(rCounter(a, b - 1)).Append(", ").Append(Convert.ToString(b));
            }
        }

        // Рекурсивный счетчик, склеивание строк с помощью +
        static string rCounter(int a, int b)
        {            
            string x;
            if (a == b)
            {
                return Convert.ToString(a);
            }
            else
            {
                return x = rCounter(a, b - 1) + ", " + Convert.ToString(b);
            }
        }

        // Рекурсивный метод подсчета суммы чисел
        static int sum(int a, int b)
        {
            int s;
            if (a == b)
            {
                return a;
            }
            else
            {
                return s = sum(a, b - 1) + b;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Введите целые числа a и b");
                int a = Convert.ToInt32(ReadLine());
                int b = Convert.ToInt32(ReadLine());

                DateTime start = DateTime.Now;
                WriteLine(rCounter(a, b));
                DateTime finish = DateTime.Now;
                WriteLine($"Время выполнения при обычном склеивании {finish - start}");

                DateTime start2 = DateTime.Now;
                WriteLine(sb(a, b));
                DateTime finish2 = DateTime.Now;
                WriteLine($"Время выполнения программы стрингбилдером {finish2 - start2}");
                
                WriteLine($"Сумма чисел от {a} до {b} = {sum(a, b)}");
                ReadKey();
            }
            catch (Exception)
            {
                WriteLine("Для непонятливых:ВВОДИТЕ ТОЛЬКО ЧИСЛА, И ТОЛЬКО ЦЕЛЫЕ!!!!!!!");
                Read();
            }            
        }
    }
}
