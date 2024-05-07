using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }


        [TestMethod]
        public void ActivePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.Active = TestData;
            Assert.AreEqual(AnCustomer.Active, TestData);
        }


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
            AnCustomer.FirstName = TestData;
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }


        [TestMethod]
        public void CustomerSuramePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "Yian";
            AnCustomer.Surname = TestData;
            Assert.AreEqual(AnCustomer.Surname, TestData);
        }


        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "p2765879@my365.dmu.ac.uk";
            AnCustomer.Email = TestData;
            Assert.AreEqual(AnCustomer.Email, TestData);
        }


        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "123 abc road LE27EH";
            AnCustomer.Address = TestData;
            Assert.AreEqual(AnCustomer.Address, TestData);
        }


        [TestMethod]
        public void CustomerAccountCreatedPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            AnCustomer.AccountCreated = TestData;
            Assert.AreEqual(AnCustomer.AccountCreated, TestData);
        }


        [TestMethod]
        public void CustomerAccountVerificationPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.AccountVerification = TestData;
            Assert.AreEqual(AnCustomer.AccountVerification, TestData);
        }

    }

    
}
