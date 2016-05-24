using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Utilities
{
    class GraphNode
    {
        public int Data { get; private set; }
        public List<GraphNode> AdjacencyList { get; set; }

        public GraphNode(int data)
        {
            Data = data;
            AdjacencyList = new List<GraphNode>();
        }
    }
}
