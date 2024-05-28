﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void CountPropertyOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            Int32 SomeCount = 0;
            AllPayments.Count = SomeCount;
            Assert.AreEqual(AllPayments.Count, SomeCount);
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
        public void TwoRecordsPresent()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            Assert.AreEqual(AllPayments.Count, 2);
        }
    }
}
