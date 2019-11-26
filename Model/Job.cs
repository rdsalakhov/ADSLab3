using System;
using System.Collections.Generic;

namespace ScheduleTask2
{
    public class Job
    {
        private static char jobNamer = 'A';

        public char Name { get; }
        
        public List<Job> InDependeces { get; set; }

        public Job OutDependence { get; set; }
        
        public int Priority { get; set; }

        public Job()
        {
            if (jobNamer == 'Z')
            {
                throw new Exception("Unable creating new job. Job limit achieved.");
            }
            Name = jobNamer;
            InDependeces = new List<Job>();
            OutDependence = null;
            Priority = -1;
            jobNamer++;
        }

        public override string ToString()
        {
            return Name.ToString();
        }

        public static void ResetJobNames()
        {
            jobNamer = 'A';
        }
    }
}