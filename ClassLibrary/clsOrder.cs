using System;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderId;
        public Int32 OrderId
        {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }

        }

        private Int32 mCustomerId;
        public Int32  CustomerId
       
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }

        }

        private Int32 mStaffId;
        public Int32 StaffId

        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }

        }

        private Boolean mShippingStatus;

        public bool ShippingStatus
        {
            get
            {
                return mShippingStatus;
            }
            set
            {
                mShippingStatus = value;
            }

        }

        private String mShippingAddress;
        public String ShippingAddress
        {
            get
            {
                return mShippingAddress; ;
            }
            set
            {
                mShippingAddress = value;
            }

        }



        private DateTime mOrderdate;
        public DateTime OrderDate
        {
            get
            {
                return mOrderdate;
            }
            set
            {
                mOrderdate = value;
            }

        }


        private Decimal mTotalPrice;
        public Decimal TotalPrice
        {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }

        }

        public bool Find(int orderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", orderId);
            DB.Execute("sproc_tblOrderFilterByOrderId");
            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mShippingStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["ShippingStatus"]);
                mOrderdate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalPrice"]);
                return true;
            }
            else
            {
                return false;
            }
            
        }


    }
}