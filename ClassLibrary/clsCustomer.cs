using System;
using System.Security.Principal;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        //private data member for the customer id property
        private Int32 mCustomerId;
        //customer id public property
        public Int32 CustomerId 
        { 
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }

            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        
        }

        //private data member for the customer first name
        private string mCustomerFirstName;
        //customer first name public property
        public string CustomerFirstName
        {
            get
            {
                //sends data out of the property
                return mCustomerFirstName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerFirstName = value;
            }
        }


        //private data member for the customer surname
        private string mCustomerSurname;
        public string CustomerSurname
        {
            get
            {
                //sends data out of the property
                return mCustomerSurname;
            }

            set
            {
                //this line of code allows data into the property
                mCustomerSurname = value;
            }
        }


        //private data member for the customer email
        private string mCustomerEmail;
        public string CustomerEmail
        { 
            get
            {
                //sends data out of the property
                return mCustomerEmail;
            }

            set
            {
                //this line of code allows data into the property
                mCustomerEmail = value;
            }
        }


        //private data member for the customer address
        private string mCustomerAddress;
        public string CustomerAddress
        {
            get
            {
                //sends data out of the property
                return mCustomerAddress;
            }
            
            set
            {
                //this line of code allows data into the property
                mCustomerAddress = value;
            }

        }


        //private data member for account creation date property
        private DateTime mAccountCreationDate;
        //account creation date public property
        public DateTime AccountCreationDate
        {
            get
            {
                //sends data out of the property
                return mAccountCreationDate;
            }

            set
            {
                //allows data into the property
                mAccountCreationDate = value;
            }
        }


        //private data member for account verification property
        private Boolean mAccountVerification;
        //account verification pubic property
        public bool AccountVerification 
        { 
            get
            {
                //sends data out of the property
                return mAccountVerification;
            }

            set
            {
                //this line of code allows data into the property
                mAccountVerification = value;
            }
        }


        public bool Find(int CustomerId)
        {
            //create an instance of he data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramater for the address id to serach for
            DB.AddParameter("@CustomerId", CustomerId);
            //if one record is found (there should be either 1 or 0)
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerSurname = Convert.ToString(DB.DataTable.Rows[0]["CustomerSurname"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mAccountCreationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["AccountCreationDate"]);
                mAccountVerification = Convert.ToBoolean(DB.DataTable.Rows[0]["AccountVerification"]);
                //return that everything worked OK
                return true;
            }

            //if no record was found
            else
            {
                //return false to show there is a problem
                return false;
            }

           
        }

    }
}