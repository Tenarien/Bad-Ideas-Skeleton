using System;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        private Int32 mOrderId;
        public int OrderId 
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

        private Int32 mOrderLineId;
        public int OrderLineId
        {
            get
            {
                return mOrderLineId;
            }
            set
            {
                mOrderLineId = value;
            }

        }

        private Int32 mBookId;
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


    }
}