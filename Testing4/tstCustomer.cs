using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {

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
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.CustomerId != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
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
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the Customer Id property
            if (AnCustomer.CustomerId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerFirstName()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a bolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the Customer first name property
            if (AnCustomer.CustomerFirstName != "Amanda")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerSurname()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a bolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the Customer surname property
            if (AnCustomer.CustomerSurname != "Yian")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerEmail()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a bolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the Customer email property
            if (AnCustomer.CustomerEmail != "p2765879@my365.dmu.ac.uk")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerAddress()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a bolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the Customer address property
            if (AnCustomer.CustomerAddress != "123 abc road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAccountCreationDate()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the AccountCreationDate property
            if (AnCustomer.AccountCreationDate != Convert.ToDateTime(30/04/2024))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

         

        [TestMethod]
        public void TestAccountVerification()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a bolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
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


    }

    
}
