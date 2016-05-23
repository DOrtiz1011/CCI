using System.Collections.Generic;
using CrackingTheCodingInterview.Utilities;

namespace CrackingTheCodingInterview.Problems
{
    static class Chap2_LinkedLists
    {
        public static LinkedList CreateTestLinkedList()
        {
            var linkedList = new LinkedList();

            linkedList.AddNode(1);
            linkedList.AddNode(1);
            linkedList.AddNode(2);
            linkedList.AddNode(3);
            linkedList.AddNode(3);
            linkedList.AddNode(4);
            linkedList.AddNode(5);
            linkedList.AddNode(6);
            linkedList.AddNode(6);

            return linkedList;
        }

        public static void Prob1_RemoveDups(LinkedList linkedList)
        {
            var dictionary = new Dictionary<int, int>();
            var currentNode = linkedList.Head;

            while (currentNode != null)
            {
                if (dictionary.ContainsKey(currentNode.Data))
                {
                    var tempNode = currentNode.NextNode;
                    linkedList.RemoveNode(currentNode);
                    currentNode = tempNode;
                }
                else
                {
                    dictionary.Add(currentNode.Data, 1);
                    currentNode = currentNode.NextNode;
                }
            }
        }
    }
}
