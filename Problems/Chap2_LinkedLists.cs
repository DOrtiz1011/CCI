using System;
using System.Collections.Generic;
using System.Text;
using CrackingTheCodingInterview.Utilities;

namespace CrackingTheCodingInterview.Problems
{
    static class Chap2_LinkedLists
    {
        public static LinkedList CreateTestLinkedList1()
        {
            var linkedList = new LinkedList();

            linkedList.AddNode(1);
            linkedList.AddNode(1);
            linkedList.AddNode(3);
            linkedList.AddNode(3);
            linkedList.AddNode(4);
            linkedList.AddNode(6);
            linkedList.AddNode(6);

            return linkedList;
        }

        public static LinkedList CreateTestLinkedList2()
        {
            var linkedList = new LinkedList();

            linkedList.AddNode(10);
            linkedList.AddNode(21);
            linkedList.AddNode(2);
            linkedList.AddNode(33);
            linkedList.AddNode(5);
            linkedList.AddNode(84);
            linkedList.AddNode(65);
            linkedList.AddNode(56);
            linkedList.AddNode(16);

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

        public static int KthToLast(LinkedList linkedList, int k)
        {
            var kthToLast = 0;
            var currentNode = linkedList.Tail;

            for (var i = linkedList.Count; i >= k && currentNode != null; i--)
            {
                kthToLast = currentNode.Data;
                currentNode = currentNode.PreviousNode;
            }

            return kthToLast;
        }

        //public static void Prob3_DeleteMiddleNode() { }

        public static void Prob4_Partition(LinkedList linkedList)
        {

        }

        public static Int64 Prob5_SumLists(LinkedList linkedList1, LinkedList linkedList2)
        {
            var sum1 = CreateInt(linkedList1);
            var sum2 = CreateInt(linkedList2);

            return sum1 + sum2;
        }

        public static Int64 Prob5_SumListsReverseOrder(LinkedList linkedList1, LinkedList linkedList2)
        {
            var sum1 = CreateIntReverseOrder(linkedList1);
            var sum2 = CreateIntReverseOrder(linkedList2);

            return sum1 + sum2;
        }

        private static Int64 CreateInt(LinkedList linkedList)
        {
            var queue = new Queue<int>();
            var linkedListNode = linkedList.Head;
            var stringBuilder = new StringBuilder();

            while (linkedListNode != null)
            {
                queue.Enqueue(linkedListNode.Data);
                linkedListNode = linkedListNode.NextNode;
            }

            while (queue.Count > 0)
            {
                var data = queue.Dequeue();
                stringBuilder.Append(data);
            }

            return Convert.ToInt64(stringBuilder.ToString());
        }

        private static Int64 CreateIntReverseOrder(LinkedList linkedList)
        {
            var stack = new Stack<int>();
            var linkedListNode = linkedList.Head;
            var stringBuilder = new StringBuilder();

            while (linkedListNode != null)
            {
                stack.Push(linkedListNode.Data);
                linkedListNode = linkedListNode.NextNode;
            }

            while (stack.Count > 0)
            {
                var data = stack.Pop();
                stringBuilder.Append(data);
            }

            return Convert.ToInt64(stringBuilder.ToString());
        }
    }
}
