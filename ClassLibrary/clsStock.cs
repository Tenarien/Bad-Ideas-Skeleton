using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mBookId;
        private DateTime mDateAdded;
        private string mTitle;
        private decimal mPrice;
        private bool mAvailable;
        private Int32 mQuantity;
        private Int32 mSupplierId;

        public clsStock()
        {
        }

        public int BookId
        {
            get
            {
                return mBookId;
            }

            set
            {
                mBookId = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }

            set
            {
                mDateAdded = value;
            }
        }
        public string Title
        {
            get
            {
                return mTitle;
            }

            set
            {
                mTitle = value;
            }
        }
        public decimal Price
        {
            get
            {
                return mPrice;
            }

            set
            {
                mPrice = value;
            }
        }
        public bool Available
        {
            get
            {
                return mAvailable;
            }

            set
            {
                mAvailable = value;
            }
        }
        public int Quantity
        {
            get
            {
                return mQuantity;
            }

            set
            {
                mQuantity = value;
            }
        }
        public int SupplierId
        {
            get
            {
                return mSupplierId;
            }

            set
            {
                mSupplierId = value;
            }
        }

        public bool Find(int bookId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookId", bookId);
            DB.Execute("sproc_tblStock_FilterByBookId");

            if (DB.Count == 1)
            {
                mBookId = Convert.ToInt32(DB.DataTable.Rows[0]["BookId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string title, string dateAdded, string price, string quantity, string supplierId)
        {
            String Error = "";
            DateTime DateTemp;
            Decimal PriceTemp;

            if(title.Length == 0)
            {
                Error = Error + "The title may not be blank : ";
            }

            if (title.Length > 50)
            {
                Error = Error + "The title may not exceed 50 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date";
            }

            try
            {
                PriceTemp = Convert.ToDecimal(price);
                if (PriceTemp < 0.00m)
                {
                    Error = Error + "The price cannot be negative : ";
                }
            }
            catch
            {
                Error = Error + "The price was not a valid price";
            }

            return Error;
        }
    }
}