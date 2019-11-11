using System;

namespace ScheduleTask2
{
    public class Job
    {
        private char jobNamer = 'A';

        public char Name { get; }

        public Job()
        {
            if (jobNamer == 'Z')
            {
                throw new Exception("Unable creating new job. Job limit achieved.");
            }
            Name = jobNamer;
            jobNamer++;
        }
    }
}