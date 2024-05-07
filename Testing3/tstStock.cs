using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock aBook = new clsStock();

            Assert.IsNotNull(aBook);
        }

        [TestMethod]
        public void BookIdPropertyOK()
        {
            clsStock aBook = new clsStock();

            int TestData = 1;

            aBook.BookId = TestData;

            Assert.AreEqual(aBook.BookId, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsStock aBook = new clsStock();

            DateTime TestData = DateTime.Now.Date;

            aBook.DateAdded = TestData;

            Assert.AreEqual(aBook.DateAdded, TestData);
        }

        [TestMethod]
        public void TitlePropertyOK()
        {
            clsStock aBook = new clsStock();

            string TestData = "blah";

            aBook.Title = TestData;

            Assert.AreEqual(aBook.Title, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsStock aBook = new clsStock();

            double TestData = 1.99;

            aBook.Price = TestData;

            Assert.AreEqual(aBook.Price, TestData);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            clsStock aBook = new clsStock();

            Boolean TestData = true;

            aBook.Available = TestData;

            Assert.AreEqual(aBook.Available, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsStock aBook = new clsStock();

            int TestData = 1;

            aBook.Quantity = TestData;

            Assert.AreEqual(aBook.Quantity, TestData);
        }

        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            clsStock aBook = new clsStock();

            int TestData = 1;

            aBook.SupplierId = TestData;

            Assert.AreEqual(aBook.SupplierId, TestData);
        }
    }
}
