using System;

namespace PR15
{
    public static class Task1
    {
        public static void PrintTask1()
        {

            double radiusCm = GetSideAndRadius("радиус в См:"); // получение радиуса
            double sideACm = GetSideAndRadius("сторону квадрата в См:"); // получение стороны квадрата

            double area1 = Math.PI + Math.Pow(radiusCm, 2); // Находим площадь круга
            double area2 = Math.Pow(sideACm, 2); // Находим площадь квадрата
            Console.WriteLine();


            if (area1 > area2) // Условие на проверку, что больше
            {
                Console.WriteLine($"Площадь круга больше!!"); // Ввыводм что площадь круга больше
            }
            else if (area1 < area2) // Проверка на равность
            {
                Console.WriteLine($"Площадь квадрата больше!!"); // Ввыводм что площадь квадрата больше
            }
            else
            {
                Console.WriteLine($" Площади равны"); // Ввыводим площади равны
            }
        }

        static double GetSideAndRadius(string value) // метод получения значения
        {
            while (true)
            {
                try // Блок исключении
                {
                    Console.Write($"Введите {value}");
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите чилсло"); // Ошибка введено не число

                }
            }
        }
    }
}
