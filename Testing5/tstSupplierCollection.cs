using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Assert.IsNotNull(AllSupplier);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierId = 3;
            TestItem.SupplierName = "Shahzaib Faryad";
            TestItem.SupplierAddress = "Leicester, united Kingdom";
            TestItem.AvailableSupplier = true;
            TestItem.ContractDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.SupplierList, TestList);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Int32 sCount = 2;
            AllSupplier.Count = sCount;
            Assert.AreEqual(AllSupplier.Count, sCount);
        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierId = 3;
            TestItem.SupplierName = "Shahzaib Faryad";
            TestItem.SupplierAddress = "Leicester, united Kingdom";
            TestItem.AvailableSupplier = true;
            TestItem.ContractDate = DateTime.Now.Date;
            AllSupplier.ThisSupplier = TestItem;
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }




        public void ListAndCountOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierId = 3;
            TestItem.SupplierName = "Shahzaib Faryad";
            TestItem.SupplierAddress = "Leicester, united Kingdom";
            TestItem.AvailableSupplier = true;
            TestItem.ContractDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;

            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }


        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Assert.AreEqual(AllSupplier.Count, 2);
        }



        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestSupplier.SupplierId = 3;
            TestSupplier.SupplierName = "Shahzaib Faryad";
            TestSupplier.SupplierAddress = "Leicester, united Kingdom";
            TestSupplier.AvailableSupplier = true;
            TestSupplier.ContractDate = DateTime.Now.Date;
            AllSuppliers.ThisSupplier = TestSupplier;
            PrimaryKey = AllSuppliers.Add();
            TestSupplier.SupplierId = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);

        }



        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestSupplier.SupplierId = 3;
            TestSupplier.SupplierName = "Shahzaib Faryad";
            TestSupplier.SupplierAddress = "Leicester, united Kingdom";
            TestSupplier.AvailableSupplier = true;
            TestSupplier.ContractDate = DateTime.Now.Date;
            AllSuppliers.ThisSupplier = TestSupplier;
            PrimaryKey = AllSuppliers.Add();
            TestSupplier.SupplierId = PrimaryKey;

            TestSupplier.SupplierId = 3;
            TestSupplier.SupplierName = "ZAIB SSS";
            TestSupplier.SupplierAddress = "LONDON, UK.";
            TestSupplier.AvailableSupplier = false;
            TestSupplier.ContractDate = DateTime.Now.Date;
            AllSuppliers.ThisSupplier = TestSupplier;
            AllSuppliers.Update();
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }



        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestSupplier.SupplierId = 3;
            TestSupplier.SupplierName = "Shahzaib Faryad";
            TestSupplier.SupplierAddress = "Leicester, united Kingdom";
            TestSupplier.AvailableSupplier = true;
            TestSupplier.ContractDate = DateTime.Now.Date;
            AllSuppliers.ThisSupplier = TestSupplier;
            PrimaryKey = AllSuppliers.Add();
            TestSupplier.SupplierId = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            AllSuppliers.Delete();
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }



        [TestMethod]
        public void ReportBySupplierNameMethodOK()
        {

            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportBySupplierName("");
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);


        }

        [TestMethod]
        public void ReportBySupplierNameNoneFound()
        {

            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportBySupplierName("Supplier Name A");
            Assert.AreEqual(0, FilteredSuppliers.Count);


        }


        [TestMethod]

        public void ReportBySupplierNameTestDataFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            Boolean OK = true;
            FilteredSuppliers.ReportBySupplierName("Shahzaib Faryad");
            if (FilteredSuppliers.Count == 2)
            {
                if (FilteredSuppliers.SupplierList[0].SupplierId != 25)
                {
                    OK = false;
                }
                if (FilteredSuppliers.SupplierList[0].SupplierId != 26)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }
    }
}
