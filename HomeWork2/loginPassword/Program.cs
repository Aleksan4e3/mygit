using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginPassword
{
    class Program
    {
        // Проверка логина и пароля
        static bool checkLogPass(string inputLogin, string inputPassword)
        {
            string login = "alex";
            string password = "qwerty123";
            if (login == inputLogin && password == inputPassword)
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
            int n = 3;
            do
            {
                Console.WriteLine("Введите логин и пароль");
                string x = Console.ReadLine();
                string y = Console.ReadLine();
                if (checkLogPass(x, y))
                {
                    Console.WriteLine("Вы вошли в систему, добро пожаловать!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    n--;
                    Console.WriteLine($"Неправильный логин или пароль, осталось попыток: {n}");
                    if (n == 0)
                    {
                        Console.WriteLine("Превышено количество попыток, попробуйте войти позже");
                        Console.ReadKey();
                    }
                }
            } while (n!=0);
            
        }
    }
}
