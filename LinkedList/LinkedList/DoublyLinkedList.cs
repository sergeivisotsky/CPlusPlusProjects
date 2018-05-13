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
        public int Data;
        public Node Prev;
        public Node Next;

        public Node(int data)
        {
            Data = data;
        }
    }

    public class DoublyLinkedList : IList
    {
        private int Size = 0;
        private int MaxSize;
        private Node Head = null;
        private Node Tail = null;


        public DoublyLinkedList(int maxSize)
        {
            MaxSize = maxSize;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                throw new Exception("Linked list is empty!");
            }

            if ((Head.Next == null))
            {
                Console.WriteLine(Head.Data);
                return;
            }

            Node node;
            Console.WriteLine(Head.Data + "\t");
            node = Head.Next;

            while (node.Next != null)
            {
                Console.WriteLine(node.Data + "\t");
                node = node.Next;
            }

            Console.WriteLine(node.Data + "\t");
        }

        public int GetSize()
        {
            return Size;
        }

        public void InsertAtPosition(int element, int position)
        {
            Node node = new Node(element);
            if (position == 1)
            {
                InsertFirst(element);
                return;
            }

            Node ptr = Head;

            for (int i = 2; i <= Size; i++)
            {
                if (i == position)
                {
                    Node temp = ptr.Next;
                    ptr.Next = node;
                    node.Prev = ptr;
                    node.Next = temp;
                    temp.Prev = node;
                }

                ptr = ptr.Next;
            }

            Size++;
        }

        public void InsertFirst(int element)
        {
            Node node = new Node(element);
            if (IsEmpty())
            {
                Head = node;
                Tail = Head;
            }
            else
            {
                Head.Prev = node;
                node.Next = Head;
                Head = node;
            }
            Size++;
        }

        public void InsertLast(int element)
        {
            Node node = new Node(element);
            if (Head == null)
            {
                Head = node;
                Tail = Head;
            }
            else
            {
                node.Prev = Tail;
                Tail.Next = node;
                Tail = node;
            }

            Size++;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public bool IsFull()
        {
            return Size == MaxSize;
        }

        public void DeleteAtPosition(int position)
        {
            if (position == 1)
            {
                if (Size == 1)
                {
                    Head = null;
                    Tail = null;
                    Size = 0;
                    return;
                }

                Head = Head.Next;
                Head.Prev = null;
                Size--;
                return;
            }

            if (position == Size)
            {
                Tail = Tail.Prev;
                Tail.Prev = null;
                Size--;
            }
            Node node = Head.Next;
            for (int i = 1; i <= Size; i++)
            {
                if (i == position)
                {
                    Node prevPtr = node.Prev;
                    Node nextPtr = node.Next;
                    prevPtr.Next = nextPtr;
                    nextPtr.Prev = prevPtr;
                    Size--;
                    return;
                }
                node = node.Next;
            }
        }

        public int NegativeElementQuantity()
        {
            Node node;
            int counter = 0;
            for (node = Head; node != Tail; node = node.Next)
            {
                if (node.Data < 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main(string[] args)
        {
            int answer;
            String yesNoAnswer;
            int element;
            int position;

            Console.Write("Input size: (max 15)");
            int maxSize = Console.Read();
            if(maxSize > 15)
            {
                Console.WriteLine("List size shouldn't be greater than 15!");
            }
            DoublyLinkedList list = new DoublyLinkedList(maxSize);
        }
    }
}
