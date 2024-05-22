using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //craete an instance of the class we want to craete 
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that is exits 
            Assert.IsNotNull(AllOrder);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //craete an instance of the class we want to craete 
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of the test data 
            clsOrder TestItem = new clsOrder();
            //set its properties 
            TestItem.ShippingStatus = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.TotalPrice = 6.50m;
            TestItem.ShippingAddress = "123 Maple Street London W1A 1AA United Kingdom";
            TestItem.OrderDate = DateTime.Now;
            //add the item to the test list
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrder.OrderList, TestList);


        }



        [TestMethod]
        public void ThisOrderPropertyOk()
        {
            // create an instance of the class we want to craete
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property 
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.ShippingStatus = true;
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.StaffId = 1;
            TestOrder.TotalPrice = 6.50m;
            TestOrder.ShippingAddress = "123 Maple Street London W1A 1AA United Kingdom";
            TestOrder.OrderDate = DateTime.Now;
            //assign the data to the property 
            AllOrder.ThisOrder = TestOrder;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void listAndCountOK()
        {
            // create an instance of the class we want to craete
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the lsit 
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //set its properties 
            TestItem.ShippingStatus = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.TotalPrice = 6.50m;
            TestItem.ShippingAddress = "123 Maple Street London W1A 1AA United Kingdom";
            TestItem.OrderDate = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrder.Count, TestList.Count);

        }


        [TestMethod]
        public void AddMehodOK()
        {
            // create an instance of the class we want to craete
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.ShippingStatus = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.TotalPrice = 6.50m;
            TestItem.ShippingAddress = "123 Maple Street London W1A 1AA United Kingdom";
            TestItem.OrderDate = DateTime.Now;
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //Add the record 
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);

        }

        [TestMethod]
        public void UpdateMehodOK()
        {
            // create an instance of the class we want to craete
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.ShippingStatus = true;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.TotalPrice = 6.50m;
            TestItem.ShippingAddress = "123 Maple Street London W1A 1AA United Kingdom";
            TestItem.OrderDate = DateTime.Now;
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //Add the record 
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //modify the test record 
            TestItem.ShippingStatus = false;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.TotalPrice = 6.50m;
            TestItem.ShippingAddress = "123 Maple Street London W1A 1AA United Kingdom";
            TestItem.OrderDate = DateTime.Now;
            //set the record based on the new test data 
            AllOrder.ThisOrder = TestItem;
            //update the record 
            AllOrder.Update();
            //find the record 
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);

        }

        [TestMethod]
        public void DeleteMehodOK()
        {
            // create an instance of the class we want to craete
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.ShippingStatus = true;
            TestItem.CustomerId = 1;
            TestItem.StaffId = 1;
            TestItem.TotalPrice = 6.50m;
            TestItem.ShippingAddress = "123 Maple Street London W1A 1AA United Kingdom";
            TestItem.OrderDate = DateTime.Now;
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //Add the record 
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record 
            AllOrder.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrder.Delete();
            //now find the record 
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);

        }








    }








}



