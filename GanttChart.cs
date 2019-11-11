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
            var nodes = (from node in dependenceTree.Jobs
                orderby node.Priority descending 
                select node).ToList();

            int currentWorkerIndex = 0;
            for (int i = 0; i < nodes.Count(); i++)
            {
                
                if (currentWorkerIndex == WorkersCount)
                {
                    currentWorkerIndex = 0;
                }
                
                
                if (currentWorkerIndex != 0)
                {
                    bool isReady = true;
                    for (int workerIndex = 0; workerIndex < currentWorkerIndex; workerIndex++)
                    {
                        if (Chart[workerIndex].Count != 0 && Chart[workerIndex].Last().OutDependence == nodes[i])
                        {
                            isReady = false;
                            break;
                        }
                    }

                    if (isReady)
                    {
                        Chart[currentWorkerIndex].Add(nodes[i]);
                        currentWorkerIndex++;
                    }
                    else
                    {
                        Chart[0].Add(nodes[i]);
                    }
                }
                else
                {
                    Chart[currentWorkerIndex].Add(nodes[i]);
                    currentWorkerIndex++;
                }
               }
        }
    }
}