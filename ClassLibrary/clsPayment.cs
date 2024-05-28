using System;
using System.Diagnostics;
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

        public string Valid(string paymentDate, string paymentMethod, string amount, string currency, bool statusCleared)
        {
            String Error = "";
            Double TestAmount;
            DateTime TestPaymentDate;

            if (paymentMethod.Length <= 0)
            {
                Error += "method should have atleast one Character";
            }
            if (paymentMethod.Length > 15)
            {
                Error += "Payment Method cant be more than 15 words.";
            }

            try
            {
                TestAmount = Convert.ToDouble(amount);
                if (TestAmount <= 0)
                {
                    Error += "Amount Should be bigger than 0.";
                }
                if (TestAmount > 2500.00)
                {
                    Error += "Limit is 2500.00";
                }
            }
            catch
            {
                Error += "Amount is in Invalid format";
            }

            try
            {
                TestPaymentDate = Convert.ToDateTime(paymentDate);
                if (TestPaymentDate < DateTime.Now.Date)
                {
                    Error = Error + "Date mustnot be in the past ";
                }
                if (TestPaymentDate > DateTime.Now.Date)
                {
                    Error = Error + "Date mustnot be in the future";
                }
            }
            catch
            {
                Error = Error + "Date is in inValid Format";
            }

            return Error;
        }
    }
}