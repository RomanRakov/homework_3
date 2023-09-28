using System;
namespace exercises
{
    enum day
    {
        Понедельник,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1\nНеобходимо определить, является ли последовательность упорядоченной по возрастанию");
            string sub = Console.ReadLine();
            int firstnumber, secondnumber;
            bool result = true;
            for (int i = 0; i + 1 < sub.Length; i++)
            {
                string firstnumber0 = sub[i].ToString();
                string secondnumber0 = sub[i + 1].ToString();
                int.TryParse(firstnumber0, out firstnumber);
                int.TryParse(secondnumber0, out secondnumber);
                if (firstnumber >= secondnumber)
                {
                    result = false;
                    Console.WriteLine($"Последовательность прерывается на следующем элементе: {secondnumber}\n");
                    break;
                }
            }
            if (result)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию\n");
            }

            Console.WriteLine("Задание 2\nНеобходимо определить достоинство карты\nВведите номер от 6 до 14");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 6:
                        Console.WriteLine("Ваша карта: 6\n");
                        break;
                    case 7:
                        Console.WriteLine("Ваша карта: 7\n");
                        break;
                    case 8:
                        Console.WriteLine("Ваша карта: 8\n");
                        break;
                    case 9:
                        Console.WriteLine("Ваша карта: 9\n");
                        break;
                    case 10:
                        Console.WriteLine("Ваша карта: 10\n");
                        break;
                    case 11:
                        Console.WriteLine("Ваша карта: Валет\n");
                        break;
                    case 12:
                        Console.WriteLine("Ваша карта: Дама\n");
                        break;
                    case 13:
                        Console.WriteLine("Ваша карта: Король\n");
                        break;
                    case 14:
                        Console.WriteLine("Ваша карта: Туз\n");
                        break;
                    default:
                        Console.WriteLine("Необходимо ввести целое число от 6 до 14\n");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Необходимо ввести целое число от 6 до 14\n");
            }

            Console.WriteLine("Задание 3\nНеобходимо вывесети данные в соответствии с таблицей\nВведите слoво:");
            string word = Console.ReadLine();
            word = word.ToLower();
            switch (word)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila\n");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol\n");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer\n");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine\n");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars\n");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal\n");
                    break;
                default:
                    Console.WriteLine("Beer\n");
                    break;
            }

            Console.WriteLine("Задание 4\nНеобходимо вывесети название дня недели\nВведите порядковый номер дня:");
            string number0 = Console.ReadLine();
            uint number;
            uint.TryParse(number0, out number);
            switch (number)
            {
                case 1:
                    Console.WriteLine(day.Понедельник);
                    break;
                case 2:
                    Console.WriteLine(day.Вторник);
                    break;
                case 3:
                    Console.WriteLine(day.Среда);
                    break;
                case 4:
                    Console.WriteLine(day.Четверг);
                    break;
                case 5:
                    Console.WriteLine(day.Пятница);
                    break;
                case 6:
                    Console.WriteLine(day.Суббота);
                    break;
                case 7:
                    Console.WriteLine(day.Воскресенье);
                    break;
                default:
                    Console.WriteLine("Необходимо ввести число от 1 до 7");
                    break;
            }
            Console.WriteLine();

            Console.WriteLine("Задание 5\nНеобходимо создать массив и найти количество кукол");
            string[] words = new string[] {"Barbie doll", "doll", "Hello Kitty", "Barbie", "Hello", "Kitty", "Barbie doll"};
            uint quan = 0;
            foreach (string element in words)
            {
                if (element == "Barbie doll" || element == "Hello Kitty")
                {
                    quan += 1 ;
                }
            }
            Console.WriteLine($"Количество кукол: {quan}");
            Console.ReadKey();
        }
    }
}
