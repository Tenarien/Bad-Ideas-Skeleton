using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsPaymentCollection
    {
        List<clsPayment> mPaymentList = new List<clsPayment>(); 
        clsPayment mThisPayment = new clsPayment();


        public clsPaymentCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblPayment_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsPayment APayment = new clsPayment();
                APayment.PaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentID"]);
                APayment.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);
                APayment.Amount = Convert.ToDouble(DB.DataTable.Rows[Index]["Amount"]);
                APayment.Currency = Convert.ToString(DB.DataTable.Rows[Index]["Currency"]);
                APayment.StatusCleared = Convert.ToBoolean(DB.DataTable.Rows[Index]["StatusCleared"]);
                APayment.PaymentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["PaymentDate"]);
                mPaymentList.Add(APayment);
                Index++;
            }
        }


        public List<clsPayment> PaymentList
        {
            get
            {
                return mPaymentList;
            }
            set
            {
                mPaymentList = value;
            }
        }

        public int Count
        {
            get
            {
                return mPaymentList.Count;
            }
            set
            {

            }
        }
        public clsPayment ThisPayment
        {
            get
            {
                return mThisPayment;
            }
            set
            {
                mThisPayment = value;
            }
        }
    }
}