namespace CrackingTheCodingInterview.Utilities
{
    class LinkedListNode
    {
        public LinkedListNode PreviousNode { get; set; }
        public LinkedListNode NextNode { get; set; }
        public int Data { get; private set; }

        public LinkedListNode(LinkedListNode previousNode, LinkedListNode nextNode, int data)
        {
            PreviousNode = previousNode;
            NextNode = nextNode;
            Data = data;
        }
    }
}
