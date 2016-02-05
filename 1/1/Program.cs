using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; int y; //Объявление двух целочисленных переменных x и y.
            x = Convert.ToInt32(Console.ReadLine()); y = Convert.ToInt32(Console.ReadLine()); //2.	Ввод с клавиатуры их значений.
            int z = x + y; //Объявление переменной z, инициализировав ее суммой x и y.
            Console.WriteLine(z); // Вывод z на экран
            //Вывод на экран сообщение о том какое z число: положительное или отрицательнлое, четное или нечетное, делиться ли оно на 5, 10, 20 без остатка!
            if (z > 0)
            {
                Console.WriteLine("z - положительное число");
            }
            else
            {
                Console.WriteLine("z - отрицательное число");
            }
            if (z %2 == 0)
            {
                Console.WriteLine("z - четное число");
            }
            else
            {
                Console.WriteLine("z - нечетное число");

            }
            if (z % 5 == 0)
            {
                Console.WriteLine("z - делиться на 5");
            }
            else
            {
                Console.WriteLine("z - не делиться на 5");

            }
            if (z % 10 == 0)
            {
                Console.WriteLine("z - делиться на 10");
            }
            else
            {
                Console.WriteLine("z - не делиться на 10");

            }
            if (z % 20 == 0)
            {
                Console.WriteLine("z - делиться на 20");
            }
            else
            {
                Console.WriteLine("z - не делиться на 20");

            }
            z = z - 1;
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
