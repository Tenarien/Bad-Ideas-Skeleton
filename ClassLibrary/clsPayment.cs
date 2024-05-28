using System;
using System.Net;

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

        public bool Find(int paymentID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PaymentID", paymentID);
            DB.Execute("sproc_tblPayment_FilterbyPaymentID");
            if (DB.Count == 1)
            {
                mPaymentID = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentID"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                mAmount = Convert.ToDouble(DB.DataTable.Rows[0]["Amount"]);
                mCurrency = Convert.ToString(DB.DataTable.Rows[0]["Currency"]);
                mStatusCleared = Convert.ToBoolean(DB.DataTable.Rows[0]["StatusCleared"]);
                mPaymentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PaymentDate"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}