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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblPayment_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;

            RecordCount = DB.Count;
            mPaymentList = new List<clsPayment>();

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

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PaymentDate", mThisPayment.PaymentDate);
            DB.AddParameter("@PaymentMethod", mThisPayment.PaymentMethod);
            DB.AddParameter("@Amount", mThisPayment.Amount);
            DB.AddParameter("@Currency", mThisPayment.Currency);
            DB.AddParameter("@StatusCleared", mThisPayment.StatusCleared);
            return DB.Execute("sproc_tblPayment_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            DB.Execute("sproc_tblPayment_Delete");
        }

        public void ReportByPaymentMethod(string PaymentMethod)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PaymentMethod", PaymentMethod);
            DB.Execute("sproc_tblPayment_FilterByPaymentMethod");
            PopulateArray(DB);
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            DB.AddParameter("@PaymentDate", mThisPayment.PaymentDate);
            DB.AddParameter("@PaymentMethod", mThisPayment.PaymentMethod);
            DB.AddParameter("@Amount", mThisPayment.Amount);
            DB.AddParameter("@Currency", mThisPayment.Currency);
            DB.AddParameter("@StatusCleared", mThisPayment.StatusCleared);
            DB.Execute("sproc_tblPayment_Update");
        }
    }
}