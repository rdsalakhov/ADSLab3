using System;

namespace ScheduleTask2
{
    public class InvalidWorkersCountException : Exception
    {
        public int Value;
        public InvalidWorkersCountException(string message, int value) : base(message)
        {
            Value = value;
        }
    }
}