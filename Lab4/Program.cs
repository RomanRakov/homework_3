using System;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнения 4.1\nПеревести число в месяц и день месяца");
            DateTime data = new DateTime();
            Console.WriteLine("Введите число:");
            string quan0 = Console.ReadLine();
            uint quan;
            uint.TryParse(quan0, out quan);
            data = data.AddDays(quan - 1);
            Console.WriteLine(data.ToString("d MMMM\n"));

            Console.WriteLine("Упражнения 4.2\nПеревести число в месяц и день месяца и обработать ичключение");
            DateTime newdata = new DateTime();
            Console.WriteLine("Введите число:");
            string newquan0 = Console.ReadLine();
            uint newquan;
            uint.TryParse(newquan0, out newquan);
            if (newquan > 1 && newquan < 365)
            {
                newdata = newdata.AddDays(newquan - 1);
                Console.WriteLine(newdata.ToString("d MMMM\n"));
            }
            else
            {
                Console.WriteLine("Вы должны ввести число от 1 до 365\n");
            }

            Console.WriteLine("Домашнее задание 4.1\nНеобходимо определить високосный год или нет\nВведите число:");
            string year0 = Console.ReadLine();
            uint year;
            uint.TryParse(year0, out year);
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Год невисокосный");
            }
            Console.ReadKey();
        }
    }
}
