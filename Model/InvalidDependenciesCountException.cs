using System;

namespace ScheduleTask2
{
    public class InvalidDependenciesCountException : Exception
    {
        public int JobCount;
        public int DependenciesCount;
        public InvalidDependenciesCountException(string message, int jobCount, int dependenciesCount) : base(message)
        {
            JobCount = jobCount;
            DependenciesCount = dependenciesCount;
        }
    }
}