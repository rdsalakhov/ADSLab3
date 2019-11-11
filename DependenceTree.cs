using System.Collections.Generic;

namespace ScheduleTask2
{
    public class DependenceTree
    {
        public DependenceTreeNode Root { get; }

        private List<DependenceTreeNode> _nodes;

        public DependenceTree(List<DependenceTreeNode> nodes, DependenceTreeNode root)
        {
            this._nodes = nodes;
            this.Root = root;
        }

        public void SetPriorities()
        {
            Queue<DependenceTreeNode> q = new Queue<DependenceTreeNode>();
            
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
                    DependenceTreeNode newnode = q.Peek();
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