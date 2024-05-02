using System;

namespace Task2
{
    /// <summary>
    /// Кастомное исключение
    /// </summary>
    internal class CustomException : Exception
    {
        public CustomException()
        { }

        public CustomException(string message) : base(message)
        { }
    }
}
