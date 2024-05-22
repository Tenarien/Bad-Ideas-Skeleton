using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //privat member data for thisOrder
        clsOrder mThisOrder = new clsOrder();


        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {


            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }



        public clsOrderCollection()
        {
            
            //object for the data connect 
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB);


        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisOrder
            //connect to the daabase 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@ShippingStatus", mThisOrder.ShippingStatus);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);

            //execture the query returning the primary key value 
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values ofthisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@ShippingStatus", mThisOrder.ShippingStatus);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            
            //execture the query returning the primary key value 
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //delete the record pointed to ny thisOrder
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            //exectute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByShippingAddress(string ShippingAddress)
        {

            //filters the records based on a full or partial shipping Address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the shipping address parameter to the database 
            DB.AddParameter("@ShippingAddress", ShippingAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByShippingAddress");
            //populate the array list with the data table 
            PopulateArray(DB);
        }
   
        void PopulateArray(clsDataConnection DB)
        {
            //populates the arraylist based on the data table in the parameter DB
            //variable for the index 
            Int32 Index = 0;
            //variable to store the recent count 
            Int32 RecordCount;
            //get the count of records 
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address object
                clsOrder AnOrder = new clsOrder();
                //read in the fields for the current record 
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnOrder.ShippingStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["ShippingStatus"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.TotalPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalPrice"]);
                AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record 
                Index++;
            }
        }
    
    
    
    }
}