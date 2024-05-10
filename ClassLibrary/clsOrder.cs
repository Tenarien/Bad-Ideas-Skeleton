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

            mOrderId = 21;
            mCustomerId = 21;
            mStaffId = 21;
            mShippingStatus = true;
            mOrderdate = Convert.ToDateTime("23/12/2024");
            mShippingAddress = "Test ShippingAddress";
            mTotalPrice = 6; 
            return true;
        }

       

    }
}