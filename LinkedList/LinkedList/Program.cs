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
        readonly int Data;
        readonly Node Prev;
        readonly Node Next;

        public Node(int data)
        {
            Data = data;
        }
    }

    class Program : IList
    {
        private readonly int Size = 0;
        private readonly int MaxSize;
        private readonly Node Head = null;
        private readonly Node Tail = null;

        public Program(int maxSize)
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
            throw new NotImplementedException();
        }

        public void InsertLast(int element)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return Size == 0;
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
