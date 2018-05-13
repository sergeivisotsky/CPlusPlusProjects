using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Tests
{
    [TestClass()]
    public class LinkedListTests
    {
        DoublyLinkedList List = new DoublyLinkedList(15);
        private readonly int Iterator = 15;
        private Random rd = new Random();

        [TestMethod()]
        public void EmptyStatusTest()
        {
            Assert.IsTrue(List.IsEmpty());
            Assert.AreEqual(0, List.GetSize());
        }

        [TestMethod()]
        public void InsertFirstTest()
        {
            for (int i = 0; i < Iterator; i++)
            {
                List.InsertFirst(rd.Next(99) + 1);
            }
            Assert.IsTrue(!List.IsEmpty());
            Assert.AreEqual(15, List.GetSize());
        }

        [TestMethod()]
        public void InsertAtPositionTest()
        {
            List.InsertFirst(45);
            List.InsertAtPosition(5, 1);
            List.Display();
            Assert.IsTrue(!List.IsEmpty());
            Assert.AreEqual(2, List.GetSize());
        }

        [TestMethod()]
        public void InsertLastTest()
        {
            for(int i = 0; i < Iterator - 1; i++)
            {
                List.InsertFirst(rd.Next(99) + 1);
            }
            List.InsertLast(76);
            Assert.IsTrue(!List.IsEmpty());
            Assert.AreEqual(15, List.GetSize());
        }

        [TestMethod()]
        public void NegativeElementQuantityTest()
        {
            List.InsertFirst(5);
            for(int i = 0; i <= 3; i++)
            {
                List.InsertAtPosition(-90, i);
            }
            List.InsertLast(7);
            Assert.AreEqual(3, List.NegativeElementQuantity());
        }

        [TestMethod()]
        public void DeleteAtPositionTest()
        {
            for(int i = 0; i <= Iterator; i++)
            {
                List.InsertAtPosition(i, i);
            }
            Assert.IsTrue(List.IsFull());
            Assert.AreEqual(15, List.GetSize());
            for(int i = 0; i <= Iterator; i++)
            {
                List.DeleteAtPosition(i);
            }
            Assert.IsTrue(List.IsEmpty());
            Assert.AreEqual(0, List.GetSize());
        }
    }
}