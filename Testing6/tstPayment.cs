using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Net;
using System.Diagnostics;

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


        string PaymentMethod = "Cash";
        string Amount = "50.5";
        string Currency = "Dollar";
        string PaymentDate = DateTime.Now.Date.ToString();
        bool StatusCleared = false;

        [TestMethod]
        public void ValidMethodOK()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentMethodMinLessOne()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            String PaymentMethod = "";
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentMethodMin()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            String PaymentMethod = "C";
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentMethodMinPlusOne()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            String PaymentMethod = "CA";
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentMethodMaxLessOne()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            String PaymentMethod = "";
            PaymentMethod = PaymentMethod.PadRight(14, 'C');
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMax()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            String PaymentMethod = "";
            PaymentMethod = PaymentMethod.PadRight(15, 'C');
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentMethodMaxPlusOne()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            String PaymentMethod = "";
            PaymentMethod = PaymentMethod.PadRight(16, 'C');
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentMethodMid()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            String PaymentMethod = "";
            PaymentMethod = PaymentMethod.PadRight(7, 'C');
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentMethodExtremeMAX()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            String PaymentMethod = "";
            PaymentMethod = PaymentMethod.PadRight(200, 'C');
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AmountExtremeMin()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            Double TestAmount = -500.00;
            String Amount = TestAmount.ToString();
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AmountMinLessOne()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            Double TestAmount = 0;
            String Amount = TestAmount.ToString();
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AmountMin()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            Double TestAmount = 1.00;
            String Amount = TestAmount.ToString();
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AmountMinPlusOne()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            Double TestAmount = 2.00;
            String Amount = TestAmount.ToString();
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AmountMaxLessOne()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            Double TestAmount = 2499.00;
            String Amount = TestAmount.ToString();
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AmountMax()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            Double TestAmount = 2500.00;
            String Amount = TestAmount.ToString();
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AmountMaxPlusOne()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            Double TestAmount = 2501.99;
            String Amount = TestAmount.ToString();
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AmountMid()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            Double TestAmount = 1250.00;
            String Amount = TestAmount.ToString();
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AmountExtremeMax()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            Double TestAmount = 12000;
            String Amount = TestAmount.ToString();
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AmountInvalidData()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            String Amount = "Invalid datatype";
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void PaymentDateExtremeMinimum()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string PaymentDate = TestDate.ToString();
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentDateMinLessOne()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string PaymentDate = TestDate.ToString();
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentDateMin()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            string PaymentDate = TestDate.ToString();
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentDateMinPlusOne()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string PaymentDate = TestDate.ToString();
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentDateExtremeMaximum()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string PaymentDate = TestDate.ToString();
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentDateInvalidDataType()
        {
            clsPayment APayment = new clsPayment();
            String Error = "";
            string PaymentDate = "Invalid Date.";
            Error = APayment.Valid(PaymentDate, PaymentMethod, Amount, Currency, StatusCleared);
            Assert.AreEqual(Error, "");
        }
    }
}
