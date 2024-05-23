using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;


namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private member data for this address
        clsCustomer mThisCustomer = new clsCustomer();


        public List<clsCustomer> CustomerList 
        { 
            get
            {
                //return the private data
                return mCustomerList;
            }
            
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }



        public int Count 
        { 
            get
            {
                //return the count of lines
                return CustomerList.Count;
            }
            
            set
            {
                //worry about later
            }
        }



        public clsCustomer ThisCustomer 
        { 
            get
            {
                //return private data 
                return mThisCustomer;
            }
            
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }


        public clsCustomerCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramaters for the stored procedure
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerSurname", mThisCustomer.CustomerSurname);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@AccountCreationDate", mThisCustomer.AccountCreationDate);
            DB.AddParameter("@AccountVerification", mThisCustomer.AccountVerification);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //adds a record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramaters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerSurname", mThisCustomer.CustomerSurname);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@AccountCreationDate", mThisCustomer.AccountCreationDate);
            DB.AddParameter("@AccountVerification", mThisCustomer.AccountVerification);

            //execute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pinted to by thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramaters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }


        public void ReportByEmail(string CustomerEmail)
        {
            //filter the records based on full or partial email
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send email paramater to the database
            DB.AddParameter("@CustomerEmail", CustomerEmail);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerEmail");
            //populate the array list with the datatable
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the paramater DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                AnCustomer.CustomerSurname = Convert.ToString(DB.DataTable.Rows[Index]["CustomerSurname"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                AnCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                AnCustomer.AccountCreationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["AccountCreationDate"]);
                AnCustomer.AccountVerification = Convert.ToBoolean(DB.DataTable.Rows[Index]["AccountVerification"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }
    }
    
}