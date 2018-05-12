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
        LinkedList linkedList = new LinkedList(15);

        [TestMethod()]
        public void EmptyStatusTest()
        {
            Assert.Fail();
        }
    }
}