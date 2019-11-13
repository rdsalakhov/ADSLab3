using System.Collections.Generic;
using System.Linq;

namespace ScheduleTask2
{
    public static class DependenceTreeCreator
    {
        public static DependenceTree CreateFromDependenceDictionary(Dictionary<char, char> dictionary, int jobCount)
        {
            
            var jobNodes = CreateListOfJobs(jobCount);

            foreach (var dependence in dictionary)
            {
                var receiver = (from jobNode in jobNodes
                    where jobNode.Name == dependence.Value
                    select jobNode).First();
                    
                var giver = (from jobNode in jobNodes
                    where jobNode.Name == dependence.Key
                    select jobNode).First();
                giver.OutDependence = receiver;
                receiver.InDependeces.Add(giver);
            }

            var root = FindRoot(jobNodes[0]); 
            return new DependenceTree(jobNodes, root);
        }

        private static Job FindRoot(Job jobNode)
        {
            while (jobNode.OutDependence != null)
            {
                jobNode = jobNode.OutDependence;
            }

            return jobNode;
        }
        
        private static List<Job> CreateListOfJobs(int jobCount)
        {
            var list = new List<Job>();
            for (int i = 0; i < jobCount; i++)
            {
                list.Add(new Job());
            }

            return list;
        }
    }
}