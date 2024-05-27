using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplier

    {
        [TestMethod]
        public void InstanceOK()
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


        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierId = 3;
            Found = ASupplier.Find(SupplierId);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestSupplierIdFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 3;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierId != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestSuppplierNameFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 3;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierName != "tarr")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestContractDateFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 3;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.ContractDate != Convert.ToDateTime("09/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAvailableSupplierFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 3;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.AvailableSupplier != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestSupplierAddressFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 3;
            Found = ASupplier.Find(SupplierId);
            if (ASupplier.SupplierAddress != "ls2")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}