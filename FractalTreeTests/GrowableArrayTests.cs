using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractalTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalTree.Tests
{
    [TestClass()]
    public class GrowableArrayTests
    {
        [TestMethod()]
        public void RemoveItemTest()
        {
            GrowableArray<int> tester = new GrowableArray<int>();


            Assert.Fail();
        }

        [TestMethod()]
        public void AddTest()
        {
            GrowableArray<int> tester = new GrowableArray<int>
            {
                5
            };
            Assert.Equals(tester.list, new int[] { 5 });
        }

        [TestMethod()]
        public void ElementAtTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void isEmptyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void numberOfItemsTest()
        {
            Assert.Fail();
        }


        [TestMethod()]
        public void GetEnumeratorTest()
        {
            Assert.Fail();
        }
    }
}