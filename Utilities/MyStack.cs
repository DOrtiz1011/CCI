using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Utilities
{
    class MyStack
    {
        private LinkedList linkedList = new LinkedList();

        public void Push(int data)
        {
            linkedList.AddNodeToHead(data);
        }

        public int Pop()
        {
            if (linkedList.Head == null)
            {
                throw new ApplicationException("stack is empty!");
            }

            var data = linkedList.Head.Data;
            linkedList.RemoveNode(linkedList.Head);

            return data;
        }

        public int Peek()
        {
            if (linkedList.Head == null)
            {
                throw new ApplicationException("stack is empty!");
            }

            return linkedList.Head.Data;
        }

        public bool IsEmpty()
        {
            return linkedList.Count == 0;
        }
    }
}
