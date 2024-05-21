using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisBook = new clsStock();

        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock aBook = new clsStock();
                aBook.BookId = Convert.ToInt32(DB.DataTable.Rows[Index]["BookId"]);
                aBook.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                aBook.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                aBook.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                aBook.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                aBook.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                aBook.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                mStockList.Add(aBook);
                Index++;
            }
        }

        public List<clsStock> StockList 
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                
            }
        }
        public clsStock ThisBook 
        {
            get
            {
                return mThisBook;
            }
            set
            {
                mThisBook = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Title", mThisBook.Title);
            DB.AddParameter("@Available", mThisBook.Available);
            DB.AddParameter("@DateAdded", mThisBook.DateAdded);
            DB.AddParameter("@Price", mThisBook.Price);
            DB.AddParameter("@Quantity", mThisBook.Quantity);
            DB.AddParameter("@SupplierId", mThisBook.SupplierId);

            return DB.Execute("sproc_tblStock_Insert");
        }
    }
}