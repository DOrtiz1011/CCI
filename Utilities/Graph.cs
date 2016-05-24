using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Utilities
{
    class Graph
    {
        public Graph(bool directed)
        {
            Nodes = new List<GraphNode>();

            if (directed)
            {
                CreateDirectedGraph();
            }
            else
            {
                CreateUndirectedGraph();
            }
        }

        public List<GraphNode> Nodes { get; private set; }

        private void CreateUndirectedGraph()
        {
            var node1 = new GraphNode(1);
            var node2 = new GraphNode(2);
            var node3 = new GraphNode(3);
            var node4 = new GraphNode(4);
            var node5 = new GraphNode(5);
            var node6 = new GraphNode(6);

            Nodes.AddRange(new List<GraphNode>() { node1, node2, node3, node4, node5, node6 });

            node1.AdjacencyList.Add(node2);
            node2.AdjacencyList.AddRange(new List<GraphNode>() { node1, node3, node5 });
            node3.AdjacencyList.AddRange(new List<GraphNode>() { node2, node4, node6 });
            node4.AdjacencyList.Add(node3);
            node5.AdjacencyList.AddRange(new List<GraphNode>() { node2, node6 });
            node6.AdjacencyList.AddRange(new List<GraphNode>() { node3, node5 });
        }

        private void CreateDirectedGraph()
        {
            var node1 = new GraphNode(1);
            var node2 = new GraphNode(2);
            var node3 = new GraphNode(3);
            var node4 = new GraphNode(4);
            var node5 = new GraphNode(5);
            var node6 = new GraphNode(6);

            Nodes.AddRange(new List<GraphNode>() { node1, node2, node3, node4, node5, node6 });

            node1.AdjacencyList.Add(node2);
            node2.AdjacencyList.Add(node5);
            node3.AdjacencyList.AddRange(new List<GraphNode>() { node2, node4 });
            
            node5.AdjacencyList.Add(node6);
            node6.AdjacencyList.Add(node3);
        }
    }
}
