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

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock aBook = new clsStock();

            Boolean Found = false;

            Int32 BookId = 21;

            Found = aBook.Find(BookId);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookIdFound()
        {
            clsStock aBook = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 BookId = 21;

            Found = aBook.Find(BookId);

            if(aBook.BookId != 21)
            { 
                OK = false; 
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsStock aBook = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 BookId = 21;

            Found = aBook.Find(BookId);

            if (aBook.DateAdded != Convert.ToDateTime("11/04/2024"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            clsStock aBook = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 BookId = 21;

            Found = aBook.Find(BookId);

            if (aBook.Title != "Test Title")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsStock aBook = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 BookId = 21;

            Found = aBook.Find(BookId);

            if (aBook.Price != 10)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            clsStock aBook = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 BookId = 21;

            Found = aBook.Find(BookId);

            if (aBook.Available != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsStock aBook = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 BookId = 21;

            Found = aBook.Find(BookId);

            if (aBook.Quantity != 100)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierIdFound()
        {
            clsStock aBook = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 BookId = 21;

            Found = aBook.Find(BookId);

            if (aBook.SupplierId != 22)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
