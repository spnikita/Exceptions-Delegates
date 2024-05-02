using System;

namespace Task1
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
