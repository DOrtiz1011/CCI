using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingTheCodingInterview.Utilities;

namespace CrackingTheCodingInterview.Problems
{
    static class Chap4_TreesAndGraphs
    {
        public static bool Prob1_RouteBetweenNodes(Graph graph, GraphNode graphNode1, GraphNode graphNode2)
        {
            //var routeExists = false;
            var queue = new Queue<GraphNode>();

            queue.Enqueue(graphNode1);

            while (queue.Count > 0)
            {
                var graphNode = queue.Dequeue();

                foreach (var adjacentGraphNode in graphNode.AdjacencyList)
                {
                    if (adjacentGraphNode == graphNode2)
                    {
                        return true;
                    }
                    else
                    {
                        queue.Enqueue(adjacentGraphNode);
                    }
                }
            }

            return false;
        }
    }
}
