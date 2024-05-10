using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mBookId;
        private DateTime mDateAdded;
        private string mTitle;
        private double mPrice;
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
        public double Price
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
            mBookId = 21;
            mDateAdded = Convert.ToDateTime("11 / 04 / 2024");
            mTitle = "Test Title";
            mPrice = 10;
            mAvailable = true;
            mQuantity = 100;
            mSupplierId =22;
            return true;
        }
    }
}