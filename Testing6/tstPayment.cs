using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing6
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsPayment APayment = new clsPayment();
            Assert.IsNotNull(APayment);
        }

        [TestMethod]
        public void PaymentIDOK()
        {
            clsPayment APayment = new clsPayment();
            Int32 TestData = 1;
            APayment.PaymentID = TestData;
            Assert.AreEqual(APayment.PaymentID, TestData);
        }

        [TestMethod]
        public void PaymentDateOK()
        {
            clsPayment APayment = new clsPayment();
            DateTime TestData = DateTime.Now.Date;
            APayment.PaymentDate = TestData;
            Assert.AreEqual(APayment.PaymentDate, TestData);
        }

        [TestMethod]
        public void PaymentMethodOK()
        {
            clsPayment APayment = new clsPayment();
            String TestData = "Cash";
            APayment.PaymentMethod = TestData;
            Assert.AreEqual(APayment.PaymentMethod, TestData);
        }

        [TestMethod]
        public void AmountOK()
        {
            clsPayment APayment = new clsPayment();
            Double TestData = 25.99;
            APayment.Amount = TestData;
            Assert.AreEqual(APayment.Amount, TestData);
        }
        
        [TestMethod]
        public void CurrencyOK()
        {
            clsPayment APayment = new clsPayment();
            String TestData = "Dollor";
            APayment.Currency = TestData;
            Assert.AreEqual(APayment.Currency, TestData);
        }
        
        [TestMethod]
        public void StatusClearedOK()
        {
            clsPayment APayment = new clsPayment();
            Boolean TestData = true;
            APayment.StatusCleared = TestData;
            Assert.AreEqual(APayment.StatusCleared, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsPayment APayment = new clsPayment();
            Boolean Found = false;
            Int32 PaymentID = 2;
            Found = APayment.Find(PaymentID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPaymentIDFound()
        {
            clsPayment APayment = new clsPayment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PaymentID = 2;

            Found = APayment.Find(PaymentID);
            if (APayment.PaymentID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPaymentDateFound()
        {
            clsPayment APayment = new clsPayment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PaymentID = 2;

            Found = APayment.Find(PaymentID);
            if (APayment.PaymentDate != Convert.ToDateTime("28/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPaymentMethodFound()
        {
            clsPayment APayment = new clsPayment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PaymentID = 2;

            Found = APayment.Find(PaymentID);
            if (APayment.PaymentMethod != "Card")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAmountFound()
        {
            clsPayment APayment = new clsPayment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PaymentID = 2;

            Found = APayment.Find(PaymentID);
            if (APayment.Amount != 50.5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCurrencyFound()
        {
            clsPayment APayment = new clsPayment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PaymentID = 2;

            Found = APayment.Find(PaymentID);
            if (APayment.Currency != "Dollar")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
        [TestMethod]
        public void TestStatusClearedFound()
        {
            clsPayment APayment = new clsPayment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 PaymentID = 2;

            Found = APayment.Find(PaymentID);
            if (APayment.StatusCleared != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
