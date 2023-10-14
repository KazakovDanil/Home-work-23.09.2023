using System;

namespace Home_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 4.1 и Упражнение 4.2
            Console.WriteLine("Упражнение 4.1 и упражнение 4.2");
            Console.WriteLine("Эта программа читает с экрана число от 1 до 365, переводит этот число в месяц и день месяца. Если пользователь ввел число " +
                "больше чем 365 или меньше 1, то программа должна вывести ошибку");
            Console.Write("Введите число - день в году от 1 до 365 и нажмите enter: ");
            string data_str = Console.ReadLine();
            bool is_true = int.TryParse(data_str, out int converted_data);
            if (is_true)
            {
                if (0 < converted_data && converted_data < 366)
                {
                    DateTime dateTime = new DateTime();
                    DateTime dt = dateTime.AddDays(converted_data - 1);
                    Console.WriteLine(dt.ToString("M", new System.Globalization.CultureInfo("ru-RU")));
                }
                else if (0 > converted_data)
                {
                    Console.WriteLine("Номер дня меньше 1");
                }
                else
                {
                    Console.WriteLine("Номер больше 365");
                }
            }
            else
            {
                Console.WriteLine("Некоректный ввод");
            }
            // Домашнее задание 4.1
            Console.WriteLine("Домашнее задание 4.1");
            Console.WriteLine("Эта программа читает с экрана 2 числа - год и день от 1 до 365 или от 1 до 366 если это високосный год," +
                " переводит этот число в месяц и день месяца. Если пользователь ввел число больше чем 365 или меньше 1, то программа" +
                " должна вывести ошибку");
            Console.Write("Введите число - год и нажмите enter: ");
            string data_year_str = Console.ReadLine();
            Console.Write("Введите число - день в году от 1 до 366 (если год високосный) или от 1 до 365 (если год не високосный) и нажмите enter: ");
            string data_day_str = Console.ReadLine();
            bool truth_of_year = int.TryParse(data_day_str, out int data_year);
            bool truth_of_day = int.TryParse(data_day_str, out int converted_day_data);
            if (truth_of_year && truth_of_day)
            {
                if (data_year > 0 && data_year < 10000)
                {
                    DateTime dateTime = new DateTime(data_year);
                    if (!DateTime.IsLeapYear(data_year))                                // Если год не високосный то выполняется этот блок
                    {
                        if (0 < converted_data && converted_data < 366)
                        {
                            DateTime dt = dateTime.AddDays(converted_day_data).AddYears(data_year);
                            Console.WriteLine(dt.ToLongDateString());
                        }
                        else if (0 > converted_day_data)
                        {
                            Console.WriteLine("Число дней меньше 1");
                        }
                        else
                        {
                            Console.WriteLine("Число дней больше 365");
                        }                                                               // Здесь Заканчивается
                    }
                    else
                    {
                        if (0 < converted_data && converted_data < 367)
                        {
                            DateTime dt = dateTime.AddDays(converted_day_data).AddYears(data_year);
                            Console.WriteLine(dt.ToLongDateString());
                        }
                        else if (0 > converted_day_data)
                        {
                            Console.WriteLine("Число дней меньше 1");
                        }
                        else
                        {
                            Console.WriteLine("Число дней больше 366");
                        }
                    }
                }
                else if (data_year < 0)
                {
                    Console.WriteLine("Номер года меньше 1");
                }
                else
                {
                    Console.WriteLine("Номер года больше 9999");
                }
            }
            else
            {
                Console.WriteLine("Некоректный ввод");
            }
            Console.ReadKey();
        }
    }
}
