using System;

namespace ScheduleTask2
{
    public class InvalidJobCountException : Exception
    {
        public int Value;
        public InvalidJobCountException(string message, int value) : base(message)
        {
            Value = value;
        }
    }
}