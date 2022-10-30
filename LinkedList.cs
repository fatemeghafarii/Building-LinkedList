using System;

namespace BuildingLinkedList
{
    public class LinkedList
    {
        private class Node
        {
            public Node(int value)
            {
                Value = value;
            }
            public int Value;
            public Node Next;
        }
        private Node First;
        private Node Last;
        public void addLast(int item)
        {
            var node = new Node(item);
            if(isEmpty())
            {
                First = Last = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }
        }
        public void addFirst(int item)
        {
            var node = new Node(item);
            if(isEmpty())
            {
                First = Last = node;
            }
            else
            {
                node.Next = First;
                First = node;
            }
        }
        public int indexOf(int item)
        {
            int index = 0;
            var current = First;
            while(current != null)
            {
                if(current.Value == item)
                {
                    return index;
                }
                else
                {
                    current = current.Next;
                    index++;
                }
            }
            return -1;
        }
        public bool contains(int item)
        {
            return indexOf(item) != -1;
        } 
        public void removeFirst()
        {
            if(isEmpty())
            {
                throw new IndexOutOfRangeException();
            }
            if(First == Last)
            {
                First = Last = null;
                return;
            }
            var second = First.Next;
            First.Next = null;
            First = second;
        }
        public void removeLast()
        {
            // [10 -> 20 -> 30]
            // previous -> 20
            // Last -> 20
            if(isEmpty())
            {
                throw new IndexOutOfRangeException();
            }
            if(First == Last)
            {
                First = Last = null;
                return;
            }
            var previous = getPrevious(Last);
            Last = previous;
            Last.Next = null;
        }
        private Node getPrevious(Node node)
        {
            var current = First;
            while(current != null)
            {
                if(current.Next == Last)
                {
                    break;
                }
                current = current.Next;
            }
            return null;
        }
        public void printAllNodes()
        {
            Node current = First;
            while(current != Last.Next)
            {
                System.Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
        private bool isEmpty()
        {
            return First == null;
        }
    }
}
