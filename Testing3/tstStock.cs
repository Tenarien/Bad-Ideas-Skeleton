﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {

        string Title = "A Good Book";
        string DateAdded = "01/01/2024";
        string Price = "10";
        string Quantity = "100";
        string SupplierId = "2";

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

            Int32 BookId = 5;

            Found = aBook.Find(BookId);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookIdFound()
        {
            clsStock aBook = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 BookId = 5;

            Found = aBook.Find(BookId);

            if(aBook.BookId != 5)
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

            Int32 BookId = 5;

            Found = aBook.Find(BookId);

            if (aBook.DateAdded != Convert.ToDateTime("31/01/2024"))
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

            Int32 BookId = 5;

            Found = aBook.Find(BookId);

            if (aBook.Title != "Percy Jackson")
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

            Int32 BookId = 5;

            Found = aBook.Find(BookId);

            if (aBook.Price != 20)
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

            Int32 BookId = 5;

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

            Int32 BookId = 5;

            Found = aBook.Find(BookId);

            if (aBook.Quantity != 10)
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

            Int32 BookId = 5;

            Found = aBook.Find(BookId);

            if (aBook.SupplierId != 4)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestValidOK()
        {
            clsStock aBook = new clsStock();
            String Error = "";
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinLessOne()
        {
            clsStock aBook = new clsStock();
            String Error = "";
            string Title = "";
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleMin()
        {
            //create an instance of the class we want to create
            clsStock aBook = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "a"; //this should be ok
            //invoke the method
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock aBook = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "aa"; //this should be ok
            //invoke the method
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TitleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock aBook = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMax()
        {
            //create an instance of the class we want to create
            clsStock aBook = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                       //invoke the method
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TitleMid()
        {
            //create an instance of the class we want to create
            clsStock aBook = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                    //invoke the method
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}
