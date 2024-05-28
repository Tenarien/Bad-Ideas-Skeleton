using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        string CustomerFirstName = "Amanda";
        string CustomerSurname = "Yian";
        string CustomerEmail = "p2765879@my365.dmu.ac.uk";
        string CustomerAddress = "125 abc road";
        string AccountCreationDate = DateTime.Now.ToShortDateString();

        /*******INSTANCES OF THE CLASS TEST*******/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }

        /*******PROPERTY OK TESTS*******/

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Int32 TestData = 1;
            AnCustomer.CustomerId = TestData;
            Assert.AreEqual(AnCustomer.CustomerId, TestData);   
        }


        [TestMethod]
        public void CustomerFirstNamePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "Amanda";
            AnCustomer.CustomerFirstName = TestData;
            Assert.AreEqual(AnCustomer.CustomerFirstName, TestData);
        }


        [TestMethod]
        public void CustomerSuramePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "Yian";
            AnCustomer.CustomerSurname = TestData;
            Assert.AreEqual(AnCustomer.CustomerSurname, TestData);
        }


        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "p2765879@my365.dmu.ac.uk";
            AnCustomer.CustomerEmail = TestData;
            Assert.AreEqual(AnCustomer.CustomerEmail, TestData);
        }


        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "123 abc road";
            AnCustomer.CustomerAddress = TestData;
            Assert.AreEqual(AnCustomer.CustomerAddress, TestData);
        }


        [TestMethod]
        public void CustomerAccountCreationDatePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            AnCustomer.AccountCreationDate = TestData;
            Assert.AreEqual(AnCustomer.AccountCreationDate, TestData);
        }


        [TestMethod]
        public void CustomerAccountVerificationPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.AccountVerification = TestData;
            Assert.AreEqual(AnCustomer.AccountVerification, TestData);
        }


        /*******find method test*******/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        /*******PROPERTY DATA TESTS*******/

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a bolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the Customer Id property
            if (AnCustomer.CustomerId != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerFirstNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a bolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the Customer first name property
            if (AnCustomer.CustomerFirstName != "a")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerSurnameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a bolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the Customer surname property
            if (AnCustomer.CustomerSurname != "a")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerEmailFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a bolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the Customer email property
            if (AnCustomer.CustomerEmail != "a@dmu.ac.uk")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerAddressFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a bolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the Customer address property
            if (AnCustomer.CustomerAddress != "125 abc road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAccountCreationDateFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the AccountCreationDate property
            if (AnCustomer.AccountCreationDate != Convert.ToDateTime("30/04/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

         

        [TestMethod]
        public void TestAccountVerificationFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a bolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the Customer address property
            if (AnCustomer.AccountVerification != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerFirstName = ""; //trigger error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerFirstName = "v"; //should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerFirstName = "vv"; //should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(19, 'v');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(20, 'v');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(10, 'v');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(21, 'v'); //should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(500, 'v'); //should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AccountCreationDateExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change to date to 100 years before
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AccountCreationDateMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change to date to 1 day before
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AccountCreationDateMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AccountCreationDateMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change to date to 1 day ahead
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AccountCreationDateExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change to date to 100 years ahead
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AccountCreationDateInvalidDate()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the AccountCreationDate to a non date value
            String AccountCreationDate = "This is not a date";
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerSurnameMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerSurname = ""; //trigger error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerSurnameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerSurname = "v"; //should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerSurnameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerSurname = "vv"; //should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerSurnameMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerSurname = "";
            CustomerSurname = CustomerSurname.PadRight(19, 'v');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerSurnameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerSurname = "";
            CustomerSurname = CustomerSurname.PadRight(20, 'v');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerSurnameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerSurname = "";
            CustomerSurname = CustomerSurname.PadRight(10, 'v');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerSurnamePlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerSurname = "";
            CustomerSurname = CustomerSurname.PadRight(21, 'v'); //should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerSurnameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerSurname = "";
            CustomerSurname = CustomerSurname.PadRight(500, 'v'); //should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = ""; //trigger error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = "v"; //should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = "vv"; //should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(49, 'v');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(50, 'v');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(25, 'v');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(51, 'v'); //should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(500, 'v'); //should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerAddress = ""; //trigger error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerAddress = "v"; //should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerAddress = "vv"; //should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(49, 'v');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(50, 'v');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(25, 'v');
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(51, 'v'); //should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(500, 'v'); //should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, CustomerAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


    }

    
}
