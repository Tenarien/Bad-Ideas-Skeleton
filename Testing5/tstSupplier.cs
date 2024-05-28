using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Testing5
{
    [TestClass]
    public class tstSupplier

    {

        String SupplierName = "Shahzaib Faryad";
        String SupplierAddress = "Leicester, United Kingdom.";
        String ContractDate = DateTime.Now.ToShortDateString();
        String AvailableSupplier = Convert.ToString(true);


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



        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "";
            Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "1";
            Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "11";
            Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "";
            SupplierName = SupplierName.PadRight(19, '1');
            Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "";
            SupplierName = SupplierName.PadRight(20, '1');
            Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "";
            SupplierName = SupplierName.PadRight(21, '1');
            Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "";
            SupplierName = SupplierName.PadRight(10, '1');
            Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "";
            SupplierName = SupplierName.PadRight(2000, '1');
            Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }









        [TestMethod]
        public void SupplierAddressMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierAddress = "";
             Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierAddressMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierAddress = "2";
             Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierAddressMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierAddress = "22";
             Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierAddressMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(49, '2');
             Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierAddressMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(50, '2');
             Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierAddressMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(51, '2');
             Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierAddressMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(25, '2');
             Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierAddressExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(5000, '2');
             Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }








        [TestMethod]
        public void ContractDateExtremeMinimum()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string ContractDate = TestDate.ToString();
             Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ContractDateMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string ContractDate = TestDate.ToString();
             Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ContractDateMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            string ContractDate = TestDate.ToString();
             Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ContractDateMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string ContractDate = TestDate.ToString();
             Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ContractDateExtremeMaximum()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string ContractDate = TestDate.ToString();
             Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ContractDateInvalidDataType()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ContractDate = "This is not a Valid Date Data Type.";
             Error = ASupplier.Valid(SupplierName, SupplierAddress, ContractDate, AvailableSupplier);
            Assert.AreEqual(Error, "");
        }

    }
}