using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var exceptions = new Exception[]
            {
                new FormatException("Значение не находится в соответствующем формате для преобразования из строки методом преобразования, например Parse ."),
                new FileNotFoundException("Файл не существует."),
                new DriveNotFoundException("Диск недоступен или не существует."),
                new DirectoryNotFoundException("Недопустимая часть пути к каталогу."),
                new CustomException("Кастомнеое исключение.")
            };
            
            foreach (var exception in exceptions)
            {
                try
                {
                    throw exception;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
