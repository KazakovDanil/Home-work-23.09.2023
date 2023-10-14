using System;

namespace Home_work
{
    internal class Program
    {
        enum WeekDays
        {
            Понедельник=1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            // Задача 1
            Console.WriteLine("Задача 1");
            Console.WriteLine("Дана последовательность из 10 чисел. Определить,является ли эта последовательность упорядоченной по возрастанию." +
                "В случае отрицательного ответа определить порядковый номер первого числа, которое нарушает данную последовательность.");
            int[] pos = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                pos[i] = random.Next(10);
            }
            Console.WriteLine(string.Join(",", pos));
            int j = 0;
            for (; j < 10; j++)
            {
                if (pos[j] > pos[j + 1])
                {
                    break;
                }
            }
            if (j == 9)
            {
                Console.WriteLine("Последовательность упорядочена");
            }
            else
            {
                Console.WriteLine($"Последовательность не упорядочена, элемент не соответствующий условию: {pos[j + 1]} под номером {j + 1}");
            }
            // Задача 2
            Console.WriteLine("Пользователь вводит номер карты от 6 до 14 включительно и выводится название карты");
            Console.Write("Введите число - номер карты от 6 до 14 и нажмите enter: ");
            try
            {
                string number_card_str = Console.ReadLine();
                int number_card = int.Parse(number_card_str);
                switch (number_card)
                {
                    case 6:
                        Console.WriteLine("Шестерка");
                        break;
                    case 7:
                        Console.WriteLine("Семерка");
                        break;
                    case 8:
                        Console.WriteLine("Восьмерка");
                        break;
                    case 9:
                        Console.WriteLine("Девятка");
                        break;
                    case 10:
                        Console.WriteLine("Десятка");
                        break;
                    case 11:
                        Console.WriteLine("Валет");
                        break;
                    case 12:
                        Console.WriteLine("Дама");
                        break;
                    case 13:
                        Console.WriteLine("Король");
                        break;
                    case 14:
                        Console.WriteLine("Туз");
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверное число");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Неверный ввод");
            }
            // Задача 3
            Console.WriteLine("Программа получает на вход название название алкоголя и выводит другое название алкоголя");
            Console.Write("Введите название алкоголя и нажмите enter");
            string name_of_alcohol = Console.ReadLine().ToLower();
            switch (name_of_alcohol)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school сounselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
            // Задача 4
            Console.WriteLine("Программа получает на вход номер дня недели и выводит название дня недели");
            Console.Write("Введите номер дня недели и нажмите enter: ");
            string name_of_day_week = Console.ReadLine();
            if (byte.TryParse(Console.ReadLine(), out byte day))
            {
                Console.WriteLine(Enum.GetName(typeof(DayOfWeek), day));
            } 
            else 
            { 
                Console.WriteLine("Неверный ввод");
            }
            // Задача 5
            Console.WriteLine("\nУпражнение 5");
            Console.WriteLine("Программа считает количество \"Hello Kitty\" и \"Barbie doll\" в массиве строк и выводит количество строк на экран");
            byte count = 0;
            string[] market = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Введите {i + 1}-ый элемент: ");
                market[i] = Console.ReadLine();
            }
            foreach (string i in market)
            {
                if ((i.ToLower().Equals("hello kitty")) | (i.ToLower().Equals("barbie doll")))
                {
                    count++;
                }
            }
            Console.WriteLine($"Кукол в сумке - {count}");
            Console.ReadKey();
        }
    }
}