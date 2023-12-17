using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PR15
{
    public static class Task2
    {   
        public static void PrintTask2()
        {
            int month = Proverka(); // получение номера месяца

            int daysInMonth = GetDaysInMonth(month); // смотрим сколько дней в месяце
            Console.WriteLine($"Количество дней в месяце: {daysInMonth}"); // выводим результат

        }
        static int GetDaysInMonth(int month)
        {
            switch (month)
            {
                // Месяцы с 31 днем
                case 1: // Январь
                case 3: // Март
                case 5: // Май
                case 7: // Июль
                case 8: // Август
                case 10: // Октябрь
                case 12: // Декабрь
                    return 31;

                // Февраль
                case 2:
                    return 28;

                // Месяцы с 30 днями
                case 4: // Апрель
                case 6: // Июнь
                case 9: // Сентябрь
                case 11: // Ноябрь
                    return 30;

                default:
                    return -1; // Некорректный номер месяца
            }
        }
        public static int Proverka()
        {
            while (true)
            {
                try // блок исключений 
                {
                    Console.Write("Введите номер месяца:");
                    int month = Convert.ToInt32(Console.ReadLine());
                    if (month < 1 || month > 12)
                    {
                        throw new Exception();
                    }
                    return month;
                }
                catch
                {
                    Console.WriteLine("Введите число от 1 до 12!!!");
                }

            }


        }
    }
}