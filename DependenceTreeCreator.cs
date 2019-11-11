using System.Collections.Generic;
using System.Linq;

namespace ScheduleTask2
{
    public static class DependenceTreeCreator
    {
        static DependenceTree CreateFromDependenceDictionary(Dictionary<char, char> dictionary, int jobCount)
        {
            
            var nodes = CreateListOfNodes(jobCount);

            foreach (var dependence in dictionary)
            {
                var receiver = (from node in nodes
                    where node.Job.Name == dependence.Value
                    select node).First();
                var giver = (from node in nodes
                    where node.Job.Name == dependence.Key
                    select node).First();
                giver.OutDependence = receiver;
                receiver.InDependeces.Add(giver);
            }

            var root = FindRoot(nodes[0]); 
            return new DependenceTree(nodes, root);
        }

        private static DependenceTreeNode FindRoot(DependenceTreeNode node)
        {
            while (node.OutDependence != null)
            {
                node = node.OutDependence;
            }

            return node;
        }
        
        private static List<DependenceTreeNode> CreateListOfNodes(int jobCount)
        {
            var list = new List<DependenceTreeNode>();
            for (int i = 0; i < jobCount; i++)
            {
                list.Add(new DependenceTreeNode(new Job()));
            }

            return list;
        }
    }
}