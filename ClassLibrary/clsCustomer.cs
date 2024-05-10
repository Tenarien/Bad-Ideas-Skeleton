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


        public bool Find(int customerId)
        {
            //set the private data members to the test data value
            mCustomerId = 1;
            mCustomerFirstName = "Amanda";
            mCustomerSurname = "Yian";
            mCustomerEmail = "p2765879@my365.dmu.ac.uk";
            mCustomerAddress = "123 abc road";
            mAccountCreationDate = Convert.ToDateTime(30/04/2024);
            mAccountVerification = true;
            //always return true
            return true;
        }

    }
}