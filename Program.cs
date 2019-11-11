using System.Collections.Generic;
using System.IO;

namespace ScheduleTask2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var tree = CreateTreeFromFile("input.txt");
            tree.SetPriorities();
            var chart = new GanttChart(3);
            chart.Fill(tree);
        }

        static DependenceTree CreateTreeFromFile(string path)
        {
            var streamReader = new StreamReader(path);

            int jobCount = int.Parse(streamReader.ReadLine());

            int dependenceCount = int.Parse(streamReader.ReadLine());

            var dependenceDict = new Dictionary<char, char>();

            for (int i = 0; i < dependenceCount; i++)
            {
                var dependencePair = streamReader.ReadLine().Split(' ');

                dependenceDict.Add(char.Parse(dependencePair[0]), char.Parse(dependencePair[1]));
            }

            return DependenceTreeCreator.CreateFromDependenceDictionary(dependenceDict, jobCount);
        }
    }
}