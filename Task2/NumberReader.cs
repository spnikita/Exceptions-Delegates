using System;

namespace Task2
{
    /// <summary>
    /// Ридер данных с консоли
    /// </summary>
    internal class NumberReader
    {
        /// <summary>
        /// Событие ввода числа
        /// </summary>
        public event Action<int> OnNumberEntered;

        /// <summary>
        /// Прочитать данные с консоли
        /// </summary>
        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Введите число 1 или 2.");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2)
                throw new CustomException("Введенное значение должно быть равно 1 или 2.");

            OnNumberEntered?.Invoke(number);
        }
    }
}
