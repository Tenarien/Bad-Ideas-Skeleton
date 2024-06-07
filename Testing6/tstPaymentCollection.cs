using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing6
{
    [TestClass]
    public class tstPaymentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            Assert.IsNotNull(AllPayments);
        }


        [TestMethod]
        public void PaymentListOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            List<clsPayment> TestList = new List<clsPayment>();
            clsPayment TestItem = new clsPayment();
            TestItem.PaymentID = 1;
            TestItem.PaymentMethod = "Cash";
            TestItem.Amount = 25.50;
            TestItem.Currency = "Pound";
            TestItem.StatusCleared = true;
            TestItem.PaymentDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllPayments.PaymentList = TestList;
            Assert.AreEqual(AllPayments.PaymentList, TestList);
        }


        [TestMethod]
        public void ThisPaymentPropertyOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            clsPayment TestItem = new clsPayment();

            TestItem.PaymentID = 1;
            TestItem.PaymentMethod = "Cash";
            TestItem.Amount = 25.50;
            TestItem.Currency = "Pound";
            TestItem.StatusCleared = true;
            TestItem.PaymentDate = DateTime.Now.Date;



            AllPayments.ThisPayment = TestItem;

            Assert.AreEqual(AllPayments.ThisPayment, TestItem);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            List<clsPayment> TestList = new List<clsPayment>();
            clsPayment TestItem = new clsPayment();

            TestItem.PaymentID = 1;
            TestItem.PaymentMethod = "Cash";
            TestItem.Amount = 25.50;
            TestItem.Currency = "Pound";
            TestItem.StatusCleared = true;
            TestItem.PaymentDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllPayments.PaymentList = TestList;

            Assert.AreEqual(AllPayments.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            clsPayment TestPayment = new clsPayment();
            Int32 PrimaryKey = 0;
            TestPayment.PaymentMethod = "Cash";
            TestPayment.Amount = 255.55;
            TestPayment.Currency = "Pound";
            TestPayment.PaymentDate = DateTime.Now;
            TestPayment.StatusCleared = false;
            AllPayments.ThisPayment = TestPayment;
            PrimaryKey = AllPayments.Add();
            TestPayment.PaymentID = PrimaryKey;
            AllPayments.ThisPayment.Find(PrimaryKey);
            Assert.AreEqual(AllPayments.ThisPayment, TestPayment);

        }

        [TestMethod]
        public void EditMethodOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            clsPayment TestPayment = new clsPayment();
            Int32 PrimaryKey = 0;
            TestPayment.PaymentMethod = "Cash";
            TestPayment.Amount = 255.55;
            TestPayment.Currency = "Pound";
            TestPayment.PaymentDate = DateTime.Now;
            TestPayment.StatusCleared = false;

            AllPayments.ThisPayment = TestPayment;

            PrimaryKey = AllPayments.Add();
            TestPayment.PaymentID = PrimaryKey;
            TestPayment.PaymentMethod = "Card";
            TestPayment.Amount = 55.55;
            TestPayment.Currency = "Dollar";
            TestPayment.PaymentDate = DateTime.Now;
            TestPayment.StatusCleared = true;
            AllPayments.ThisPayment = TestPayment;
            AllPayments.Update();
            AllPayments.ThisPayment.Find(PrimaryKey);
            Assert.AreEqual(AllPayments.ThisPayment, TestPayment);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            clsPayment TestPayment = new clsPayment();
            Int32 PrimaryKey = 0;
            TestPayment.PaymentID = PrimaryKey;
            TestPayment.PaymentMethod = "Cash";
            TestPayment.Amount = 255.55;
            TestPayment.Currency = "Pound";
            TestPayment.PaymentDate = DateTime.Now;
            TestPayment.StatusCleared = false;

            AllPayments.ThisPayment = TestPayment;
            PrimaryKey = AllPayments.Add();
            TestPayment.PaymentID = PrimaryKey;
            AllPayments.ThisPayment.Find(PrimaryKey);

            AllPayments.Delete();
            Boolean Found = AllPayments.ThisPayment.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }



        [TestMethod]
        public void ReportByPaymentMethodMethodOK()
        {

            clsPaymentCollection AllPayments = new clsPaymentCollection();

            clsPaymentCollection FilteredPayments = new clsPaymentCollection();
            FilteredPayments.ReportByPaymentMethod("");

            Assert.AreEqual(AllPayments.Count, FilteredPayments.Count);
        }

        [TestMethod]
        public void ReportByPaymentMethodNoneFound()
        {
            clsPaymentCollection FilteredPayments = new clsPaymentCollection();
            FilteredPayments.ReportByPaymentMethod("CASHARD");
            Assert.AreEqual(0, FilteredPayments.Count);
        }

        [TestMethod]

        public void ReportByPaymentMethodTestDataFound()
        {
            clsPaymentCollection FilteredPayments = new clsPaymentCollection();
            Boolean OK = true;
            FilteredPayments.ReportByPaymentMethod("Card");
            if (FilteredPayments.Count == 2)
            {
                if (FilteredPayments.PaymentList[0].PaymentID != 24)
                {
                    OK = false;
                }
                if (FilteredPayments.PaymentList[0].PaymentID != 25)
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
