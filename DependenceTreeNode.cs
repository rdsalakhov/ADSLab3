using System.Collections.Generic;

namespace ScheduleTask2
{
    public class DependenceTreeNode
    {
        public Job Job { get; }

        public List<DependenceTreeNode> InDependeces { get; set; }

        public DependenceTreeNode OutDependence { get; set; }
        
        public int Priority { get; set; }

        public DependenceTreeNode(Job job)
        {
            this.Job = job;
            InDependeces = new List<DependenceTreeNode>();
            OutDependence = null;
            Priority = -1;
        }
    }
}