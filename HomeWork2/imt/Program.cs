using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imt
{
    using static Console;
    using static Convert;
    class Program
    {
        // Расчет ИМТ
        static double imt(double m, double h)
        {
            double i = m / (h * h);
            return i;
        }
        
        // Определяет, соответствует ИМТ норме или нет
        static bool checkImt(double imt1)
        {
            if (imt1>=18.5 && imt1<=25)
            {
                return true; //все в норме))
            }
            else
            {
                return false; // все плохо((
            }
        }

        // Защита от дурака
        static double foolproof()
        {
            Double x = 0;
            bool prot = false;
            while (!prot)
            {
                prot = Double.TryParse(ReadLine(), out x);
                if (prot)
                {
                    break;
                }
                WriteLine("Значение не допустимо, повторите ввод");                
            }
            return x;
        }
        static void Main(string[] args)
        {
            WriteLine("Введите свой вес");
            double x = foolproof();
            WriteLine("Введите свой рост в метрах");
            double y = foolproof();            

            if (checkImt(imt(x, y)))
            {
                WriteLine("Вес в норме!");
            }
            else if (imt(x, y) < 18.5)
            {
                int a = ToInt32(18.5 * y * y - x);
                WriteLine($"Недостаточная масса тела. Нужно набрать {a} кг до нормы");
            }
            else
            {
                int a = ToInt32(x - 25 * y * y);
                WriteLine($"Избыточная масса тела. Нужно похудеть на {a} кг");
            }
            ReadKey();
        }
    }
}
