using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashka
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("5 см\n10 см\n7 см");

            Console.WriteLine();
            double sideACm = GetWerebleDouble("стороны треугольника A cm");
            double sideBCm = GetWerebleDouble("стороны треугольника B cm");
            double sideCCm = GetWerebleDouble("стороны треугольника C cm");

            double pirimetr = (sideACm + sideBCm + sideCCm) / 2;
            
            double area = (Math.Sqrt(pirimetr * (pirimetr - sideACm) * (pirimetr - sideBCm) * (pirimetr - sideCCm)));
            Console.WriteLine($"Площадь: {area}\nПериметр: {pirimetr}");
            Console.WriteLine();
                
            double x = GetWerebleDouble("x");
            double a = GetWerebleDouble("a");
            double z1 = (Math.Pow(x, 2.0) + (2.0 * x) - 3.0 + (x + 1) * Math.Sqrt(Math.Pow(x, 2.0) - 9.0)) / (Math.Pow(x, 2.0) - (2.0 * x) - 3.0 + (x - 1) * Math.Sqrt(Math.Pow(x, 2.0) - 9.0));
            double z2 = (1.0 / 4.0) - (1.0 / 4.0) * Math.Sin((5.0 / 2.0) - 8.0 * a);
            Console.WriteLine($"Вычесления по формуле для z1: {z1}\nВычесления по формуле для z2: {z2}");

        }


        private static double GetWerebleDouble(string value)
        {
            while (true)
            {
                try
                {
                    
                    Console.Write($"Введите число для {value}:");
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите число, а не буквы:");
                }
            }
        }

    }
}
