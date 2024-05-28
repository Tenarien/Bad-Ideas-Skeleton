using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {

        string Title = "A Good Book";
        string DateAdded = DateTime.Now.ToShortDateString();
        string Price = "9.99";
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

            decimal TestData = 1.99m;

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

            if (aBook.DateAdded != Convert.ToDateTime("25/05/2024"))
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

            if (aBook.Price != 19.99m)
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
            string Title = "";
            Title = Title.PadRight(49, 'a');
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
            string Title = "";
            Title = Title.PadRight(50, 'a');
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
            string Title = "";
            Title = Title.PadRight(25, 'a');
            //invoke the method
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock aBook = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "";
            Title = Title.PadRight(51, 'a');
            //invoke the method
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock aBook = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "";
            Title = Title.PadRight(500, 'a');
            //invoke the method
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsStock aBook = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock aBook = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock aBook = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock aBook = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock aBook = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock aBook = new clsStock();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string DateAdded = "This is not a date";
            //invoke the method
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMin()
        {
            clsStock aBook = new clsStock();
            String Error = "";
            Decimal TestPrice = -100.00m;
            string Price = TestPrice.ToString();
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock aBook = new clsStock();
            String Error = "";
            Decimal TestPrice = -1.00m;
            string Price = TestPrice.ToString();
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsStock aBook = new clsStock();
            String Error = "";
            Decimal TestPrice = 0.00m;
            string Price = TestPrice.ToString();
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock aBook = new clsStock();
            String Error = "";
            Decimal TestPrice = 1.00m;
            string Price = TestPrice.ToString();
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            clsStock aBook = new clsStock();
            String Error = "";
            string Price = "This is not a number";
            Error = aBook.Valid(Title, DateAdded, Price, Quantity, SupplierId);
            Assert.AreNotEqual(Error, "");
        }


    }
}
