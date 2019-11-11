using System.Collections.Generic;

namespace ScheduleTask2
{
    public class DependenceTree
    {
        public Job Root { get; }

        public List<Job> Jobs { get; }

        public DependenceTree(List<Job> jobs, Job root)
        {
            this.Jobs = jobs;
            this.Root = root;
        }

        public void SetPriorities()
        {
            Queue<Job> q = new Queue<Job>();
            
            if (Root == null)
            {
                return;
            }
            q.Enqueue(Root);

            int priorityIndex = 0;
            while (true)
            {
                int nodeCount = q.Count;
                if (nodeCount == 0)
                {
                    return;
                }
                
                while (nodeCount > 0)
                {
                    Job newnode = q.Peek();
                    newnode.Priority = priorityIndex;
                    priorityIndex++;
                    q.Dequeue();
                    foreach (var dependentNode in newnode.InDependeces)
                    {
                        q.Enqueue(dependentNode);
                    }
                    nodeCount--;
                }
            }
        }
    }
}