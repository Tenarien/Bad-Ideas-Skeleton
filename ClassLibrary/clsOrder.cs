using System;
using System.Diagnostics;
using System.IO;
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
        public Int32 CustomerId

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

        public string Valid(string customerId, string staffId, string orderDate, string totalPrice, string shippingAddress)
        {
            //create a string variable to store the error 
            String Error = "";
            //create a temporary variable to store the date values 
            DateTime DateTemp;
            Decimal PriceTemp;
            int CustomerTemp;
            int StaffTemp; 


            //if the ShippingAddress is blank 
            if (shippingAddress.Length == 0)
            {
                //record the error 
                Error = Error + "The Shipping Address may not be blank : ";
            }
            //if the shipping address is greater than 50 characters 
            if (shippingAddress.Length > 50)
            {
                //record the error 
                Error = Error + "The Shipping Address must be less than 50 characters : ";
            }
            
            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);

                if (DateTemp < DateComp) //compare dateAdded with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            try
            {
                PriceTemp = Convert.ToDecimal(totalPrice);
                if (PriceTemp < 0.00m)
                {
                    Error = Error + "The price cannot be negative : ";
                }
            }
            catch
            {
                Error = Error + "The price was not a valid price";
            }

            try
            {
                CustomerTemp = Convert.ToInt32(CustomerId);
                if (CustomerTemp < 0.00m)
                {
                    Error = Error + "The CustomerId cannot be negative : ";
                }
            }
            catch
            {
                Error = Error + "The CustomerId was not a valid number";
            }

            try
            {
                    StaffTemp = Convert.ToInt32(StaffId);
                if (StaffTemp < 0.00m)
                {
                    Error = Error + "The StaffId cannot be negative : ";
                }
            }
            catch
            {
                Error = Error + "The StaffId was not a valid number";
            }


            //return any error messages 
            return Error;
        }
    }
            
}


 