using System.Collections.Generic;
using System.Linq;

namespace ScheduleTask2
{
    public class GanttChart
    {
        public int WorkersCount { get; }
        
        public List<List<Job>> Chart { get; private set; }

        public GanttChart(int workersCount)
        {
            this.WorkersCount = workersCount;
            Chart = new List<List<Job>>();
            for (int i = 0; i < workersCount; i++)
            {
                Chart.Add(new List<Job>());
            }
        }    
        
        public void Fill(DependenceTree dependenceTree)
        {
            var jobs = (from job in dependenceTree.Jobs
                orderby job.Priority descending 
                select job).ToList();

            int currentWorkerIndex = 0;
            int workerIndexShift = 0;

            bool isReady;
            foreach (var job in jobs)
            {
                if (currentWorkerIndex == Chart.Count)
                {
                    currentWorkerIndex = workerIndexShift;
                    workerIndexShift = 0;
                }
                isReady = CheckJob(job, currentWorkerIndex, Chart[currentWorkerIndex].Count);
                if (!isReady)
                {
                    var oldWorkerIndex = currentWorkerIndex;

                    var ascendingWorkers = from worker in Chart
                                           orderby worker.Count ascending
                                           select worker;

                    foreach (var worker in ascendingWorkers)
                    {
                        currentWorkerIndex = Chart.FindIndex(x => x == worker);
                        if (CheckJob(job, currentWorkerIndex, Chart[currentWorkerIndex].Count))
                        {
                            Chart[currentWorkerIndex].Add(job);
                            break;
                        }
                    }

                    workerIndexShift = currentWorkerIndex + 1;
                    currentWorkerIndex = oldWorkerIndex;
                }
                else
                {
                    Chart[currentWorkerIndex].Add(job);
                    currentWorkerIndex++;
                }
            }
        }

        private bool CheckJob(Job job, int suggestedWorkerIndex, int suggestedJobIndex)
        {
            for (int i = 0; i < suggestedWorkerIndex; i++)
            {
                var worker = Chart[i];
                for (int j = suggestedJobIndex; j < worker.Count; j++)
                {
                    if (worker[j].OutDependence == job)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}