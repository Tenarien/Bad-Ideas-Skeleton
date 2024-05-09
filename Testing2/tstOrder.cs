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
            AnOrder.UserId = TestData;
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


    }
}
