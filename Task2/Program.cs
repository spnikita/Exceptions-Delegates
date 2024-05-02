using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberReader = new NumberReader();
            numberReader.OnNumberEntered += SortList;

            while (true)
            {
                try
                {
                    numberReader.Read();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex);
                }
                catch (CustomException ex)
                {
                    Console.WriteLine(ex);
                }

                Console.WriteLine("Введите 'x' для выхода из программы или любой символ для продолжения");
                var exit = Console.ReadLine();
                if (exit != "x")
                    continue;

                break;
            }           
        }

        static void SortList(int number)
        {
            var values = new List<string>
            {
                "Иванов",
                "Петров",
                "Сидоров",
                "Федоров",
                "Смирнов"
            };

            IEnumerable<string> sortedValues;

            switch (number)
            {
                case 1:
                    Console.WriteLine("Исходный список фамилий: " + string.Join(", ", values));
                    sortedValues = values.OrderBy(el => el);
                    Console.WriteLine("Отсортированный список фамилий (А-Я): " + string.Join(", ", sortedValues));
                    break;
                case 2:
                    Console.WriteLine("Исходный список фамилий: " + string.Join(", ", values));
                    sortedValues = values.OrderByDescending(el => el);
                    Console.WriteLine("Отсортированный список фамилий (Я-А): " + string.Join(", ", sortedValues));
                    break;
                default:
                    break;
            }
        }
    }
}
