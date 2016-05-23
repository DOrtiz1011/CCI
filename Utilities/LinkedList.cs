using System;
using System.Text;

namespace CrackingTheCodingInterview.Utilities
{
    class LinkedList
    {
        public LinkedListNode Head { get; private set; }
        public LinkedListNode Tail { get; private set; }
        public int Count { get; private set; }

        public void AddNode(int data)
        {
            if (Head == null && Tail == null)
            {
                // empty list add new head
                Head = new LinkedListNode(null, null, data);
                Tail = Head;   // only one node so head and tail are the same
                Count++;
            }
            else
            {
                var newNode = new LinkedListNode(null, null, data);
                Tail.NextNode = newNode;
                newNode.PreviousNode = Tail;
                Tail = newNode;
                Count++;
            }
        }

        public void RemoveNode(LinkedListNode nodeToRemove)
        {
            if (nodeToRemove == Head)
            {
                Head = Head.NextNode;
                Head.PreviousNode = null;
            }
            else if (nodeToRemove == Tail)
            {
                Tail = Tail.PreviousNode;
                Tail.NextNode = null;
            }
            else
            {
                nodeToRemove.PreviousNode.NextNode = nodeToRemove.NextNode;
                nodeToRemove.NextNode.PreviousNode = nodeToRemove.PreviousNode;
                Count--;
            }

            nodeToRemove.NextNode = null;
            nodeToRemove.PreviousNode = null;
            nodeToRemove = null;
            Count--;
        }

        public void PrintLinkedList()
        {
            var stringBuilder = new StringBuilder();

            if (Head == null)
            {
                stringBuilder.AppendLine("List is empty");
            }
            else
            {
                var currentNode = Head;

                while (currentNode != null)
                {
                    stringBuilder.AppendLine(currentNode.Data.ToString());
                    currentNode = currentNode.NextNode;
                }
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
