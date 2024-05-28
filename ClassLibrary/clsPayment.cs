using System;

namespace ClassLibrary
{
    public class clsPayment
    {
        private Int32 mPaymentID;
        private DateTime mPaymentDate;
        private String mPaymentMethod;
        private Double mAmount;
        private String mCurrency;
        private Boolean mStatusCleared;



        public int PaymentID
        {
            get { return mPaymentID; }
            set { mPaymentID = value; }
        }

        public DateTime PaymentDate
        {
            get { return mPaymentDate; }
            set { mPaymentDate = value; }
        }
        public string PaymentMethod
        {
            get { return mPaymentMethod; }
            set { mPaymentMethod = value; }
        }
        public double Amount
        {
            get { return mAmount; }
            set { mAmount = value;}
        }
        
        public string Currency
        {
            get { return mCurrency; }
            set { mCurrency = value; }
        }
        public bool StatusCleared
        {
            get { return mStatusCleared; }
            set { mStatusCleared= value; }
        }
    }
}