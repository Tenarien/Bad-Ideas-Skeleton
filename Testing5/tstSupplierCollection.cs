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
    }
}
