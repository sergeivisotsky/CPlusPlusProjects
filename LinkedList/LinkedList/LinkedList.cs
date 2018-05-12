using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    interface IList
    {
        bool IsEmpty();

        bool IsFull();

        int GetSize();

        void InsertFirst(int element);

        void InsertAtPosition(int element, int position);

        void InsertLast(int element);

        void Display();

        void DeleteAtPosition(int position);

        int NegativeElementQuantity();
    }

    class Node
    {
        int Data;
        public Node Prev;
        public Node Next;

        public Node(int data)
        {
            Data = data;
        }
    }

    class LinkedList : IList
    {
        private int Size = 0;
        private int MaxSize;
        private Node Head = null;
        private Node Tail = null;

        public LinkedList(int maxSize)
        {
            MaxSize = maxSize;
        }

        public void DeleteAtPosition(int position)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public int GetSize()
        {
            return Size;
        }

        public void InsertAtPosition(int element, int position)
        {
            throw new NotImplementedException();
        }

        public void InsertFirst(int element)
        {
            Node node = new Node(element);
            if(IsEmpty())
            {
                Head = node;
                Tail = Head;
            } else
            {
                Head.Prev = node;
                node.Next = Head;
                Head = node;
            }
            Size++;
        }

        public void InsertLast(int element)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public bool IsFull()
        {
            return Size == MaxSize;
        }

        public int NegativeElementQuantity()
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
        }
    }
}
