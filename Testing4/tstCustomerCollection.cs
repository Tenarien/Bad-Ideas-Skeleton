using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }


        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.AccountVerification = true;
            TestItem.CustomerId = 1;
            TestItem.CustomerFirstName = "Amanda";
            TestItem.CustomerSurname = "Yian";
            TestItem.CustomerEmail = "p2765879@my365.dmu.ac.uk";
            TestItem.CustomerAddress = "125 abc road";
            TestItem.AccountCreationDate = DateTime.Now;
            //add the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.AccountVerification = true;
            TestCustomer.CustomerId = 1;
            TestCustomer.CustomerFirstName = "Amanda";
            TestCustomer.CustomerSurname = "Yian";
            TestCustomer.CustomerEmail = "p2765879@my365.dmu.ac.uk";
            TestCustomer.CustomerAddress = "125 abc road";
            TestCustomer.AccountCreationDate = DateTime.Now;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.AccountVerification = true;
            TestItem.CustomerId = 1;
            TestItem.CustomerFirstName = "Amanda";
            TestItem.CustomerSurname = "Yian";
            TestItem.CustomerEmail = "p2765879@my365.dmu.ac.uk";
            TestItem.CustomerAddress = "125 abc road";
            TestItem.AccountCreationDate = DateTime.Now;
            //add the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AccountVerification = true;
            TestItem.CustomerId = 1;
            TestItem.CustomerFirstName = "Amanda";
            TestItem.CustomerSurname = "Yian";
            TestItem.CustomerEmail = "p2765879@my365.dmu.ac.uk";
            TestItem.CustomerAddress = "125 abc road";
            TestItem.AccountCreationDate = DateTime.Now;
            //set ThisAddress to the test data
            AllCustomers.ThisCustomer = TestItem;
            // add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that 2 values are equal
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AccountVerification = true;
            TestItem.CustomerId = 1;
            TestItem.CustomerFirstName = "Amanda";
            TestItem.CustomerSurname = "Yian";
            TestItem.CustomerEmail = "p2765879@my365.dmu.ac.uk";
            TestItem.CustomerAddress = "125 abc road";
            TestItem.AccountCreationDate = DateTime.Now;
            //set ThisAddress to the test data
            AllCustomers.ThisCustomer = TestItem;
            // add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary of the test data
            TestItem.CustomerId = PrimaryKey;
            //modify the test records
            TestItem.AccountVerification = false;
            TestItem.CustomerFirstName = "ama";
            TestItem.CustomerSurname = "yan";
            TestItem.CustomerEmail = "abc@dmu.ac.uk";
            TestItem.CustomerAddress = "125 abc road";
            TestItem.AccountCreationDate = DateTime.Now;
            //set ThisAddress to the test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if ThisCCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }








    }
}
