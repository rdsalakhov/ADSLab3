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

        
    }
}