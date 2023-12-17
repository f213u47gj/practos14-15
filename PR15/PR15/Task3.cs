using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PR15
{
    public static class Task3
    {
        public static void PrintTask3() 
        {

            double num1 = GetNumber("первое число:"); // ввод числа
            double num2 = GetNumber("второе число:"); // ввод числа
            double num3 = GetNumber("третье число:"); // ввод числа
            Console.WriteLine();
            Console.WriteLine($"Первое число:{num1}\nПервое число в квадрате:{Test(num1)}\n" +
                              $"Второе число:{num2}\nВторое число в квадрате:{Test(num2)}\n" +
                              $"Третье число:{num3}\nТретье число в квадрате:{Test(num3)}"); // вывод резлультата

        }
        static double GetNumber(string value)
        {
            while (true) // цикл
            {
                try // блок исключений
                {
                    Console.Write($"Введите {value}");
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите вещественное чилсло"); // Ошибка введено не число

                }
            }
        }
        static double Test(double value)
        {
            if (value > 0) // проверка на отрицательное
            {
                return Math.Pow(value, 2);
            }
            else
            {
                return value;
            }
        }

    }
}
