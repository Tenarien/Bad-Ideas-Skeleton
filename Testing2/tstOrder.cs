using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass the method 
        string CustomerId = "1";
        string StaffId = "1";
        string OrderDate = DateTime.Now.ToShortDateString();
        string TotalPrice = "6.50";
        string ShippingAddress = "123 Maple Street London W1A 1AA United Kingdom";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ShippingStatusPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.ShippingStatus = TestData;
            Assert.AreEqual(AnOrder.ShippingStatus, TestData);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.CustomerId = TestData;
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.StaffId = TestData;
            Assert.AreEqual(AnOrder.StaffId, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void TotalPricePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Decimal TestData = 6;
            AnOrder.TotalPrice = TestData;
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void ShippingAddressPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "123 Maple Street London W1A 1AA United Kingdom";
            AnOrder.ShippingAddress = TestData;
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);
        }

        [TestMethod]
        public void FindMethod()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 1;

            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;

            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;

            Found = AnOrder.Find(CustomerId);
            if (AnOrder.CustomerId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 1;

            Found = AnOrder.Find(StaffId);
            if (AnOrder.CustomerId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShippingStatusFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;

            Found = AnOrder.Find(OrderId);
            if (AnOrder.ShippingStatus != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;

            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderDate != Convert.ToDateTime("12/04/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestShippingAddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;

            Found = AnOrder.Find(OrderId);
            if (AnOrder.ShippingAddress != "123 Maple Street\r\nLondon\r\nW1A 1AA\r\nUnited Kingdom")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;

            Found = AnOrder.Find(OrderId);
            if (AnOrder.TotalPrice != (decimal)6.50)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string ShippingAddress = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(49, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMax()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(50, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMid()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            ShippingAddress = ShippingAddress.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //set the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //set the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable 
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date variable to a string variable
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            String OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            String OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateInvalidDate()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void TotalPriceExtremeMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            decimal TestPrice = -1000000m;
            string TotalPrice = TestPrice.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            Decimal TestPrice = -1.00m;
            string TotalPrice = TestPrice.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            Decimal TestPrice = 0.00m;
            string TotalPrice = TestPrice.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            Decimal TestPrice = 1.00m;
            string TotalPrice = TestPrice.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            string TotalPrice = "This is not a number";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdExtremeMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            int TestCustomer = -1000000;
            string CustomerId = TestCustomer.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            int TestCustomer = 0;
            string CustomerId = TestCustomer.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIdMin()
        {

            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            int TestCustomer = 1;
            string CustomerId = TestCustomer.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            int TestCustomer = 2;
            string CustomerId = TestCustomer.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void CustomerIdInvalidData()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            string CustomerId = "This is not a valid number";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdExtremeMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            int TestStaff = -1000000;
            string CustomerId = TestStaff.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffIdMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            int TestStaff = 0;
            string StaffId = TestStaff.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffIdMin()
        {

            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            int TestStaff = 1;
            string StaffId = TestStaff.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            int TestStaff = 2;
            string StaffId = TestStaff.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffIdInvalidData()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            string StaffId = "This is not a valid number";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, StaffId, OrderDate, TotalPrice, ShippingAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

       

    }
}




