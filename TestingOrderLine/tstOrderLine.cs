using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingOrderLine
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void OrderLineIdPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            int TestData = 1;

            AnOrderLine.OrderLineId = TestData;

            Assert.AreEqual(AnOrderLine.OrderLineId, TestData);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            int TestData = 1;

            AnOrderLine.OrderId = TestData;

            Assert.AreEqual(AnOrderLine.OrderId, TestData);
        }

        [TestMethod]
        public void BookIdPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            int TestData = 1;

            AnOrderLine.BookId = TestData;

            Assert.AreEqual(AnOrderLine.BookId, TestData);
        }

    }
}
