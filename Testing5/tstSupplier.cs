using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier

    {
        [TestMethod]
        public void TestMethod1()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }


        [TestMethod]
        public void SupplierId()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnSupplier.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierId, TestData);
        }

        [TestMethod]
        public void ContractDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnSupplier.ContractDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.ContractDate, TestData);

        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "Sharon";
            //assign the data to the property
            AnSupplier.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierName, TestData);
        }

        [TestMethod]
        public void SupplierAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "london";
            //assign the data to the property
            AnSupplier.SupplierAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierAddress, TestData);
        }
        [TestMethod]
        public void AvailableSupplierPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnSupplier.AvailableSupplier = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.AvailableSupplier, TestData);
        }
    }
}