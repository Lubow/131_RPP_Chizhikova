using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int parol;
          
            for (int i = 1; i<4; i++)
            { Console.WriteLine("Введите пароль: ");
                parol = Convert.ToInt32(Console.ReadLine());
                if(parol==123)
                {
                    Console.WriteLine("Верный пароль");
                    Console.Write("Осталось попыток: ");
                    Console.Write(4 - i);
                }
                else
                {
                    Console.Write("Осталось попыток: ");
                    Console.Write(4-i);
                    Console.WriteLine("Неверный пароль");
                    Console.WriteLine("Повторите попытку");
                }
                Console.ReadKey();
            }
        }
    }
}
