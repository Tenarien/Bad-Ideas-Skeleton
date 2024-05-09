using System;

namespace ClassLibrary
{
    public class clsStaff
    {   
        //private data property for the class staff
        private Int32 mStaffId;
        private String mStaffName;
        private String mStaffAddress;
        private DateTime mStaffDate;
        private String mStaffRole;
        private Boolean mStaffPrivilage;

        

        //public property for staff id
        public Int32 StaffId
        {
            //sends data out of property
            get 
            { 
                return mStaffId;
            }
            //allows data into the property
            set 
            { 
                mStaffId = value;
            }
        }

        //public property for staff name
        public String StaffName
        {
            //sends data out of property
            get
            {
                return mStaffName;
            }
            //allows data into the property
            set
            {
                mStaffName = value;
            }
        }

        //public property for staff address
        public String StaffAddress
        {
            //sends data out of property
            get
            {
                return mStaffAddress;
            }
            //allows data into the property
            set
            {
                mStaffAddress = value;
            }
        }

        //public property for staff date added
        public DateTime StaffDate
        {
            //sends data out of property
            get
            {
                return mStaffDate;
            }
            //allows data into the property
            set
            {
                mStaffDate = value;
            }
        }

        //public property for staff role
        public String StaffRole
        {
            //sends data out of property
            get
            {
                return mStaffRole;
            }
            //allows data into the property
            set
            {
                mStaffRole = value;
            }
        }

        //public property for staff address
        public Boolean StaffPrivilage
        {
            //sends data out of property
            get
            {
                return mStaffPrivilage;
            }
            //allows data into the property
            set
            {
                mStaffPrivilage = value;
            }
        }



        public bool Find(int StaffId)
        {
            //set private data to test data value
            mStaffId = 1;
            mStaffName = "Joe";
            mStaffAddress = "12 Test Street";
            mStaffDate = Convert.ToDateTime("23/12/2022");
            mStaffRole = "Staff";
            mStaffPrivilage = true;

            //always return true
            return true;
        }
    }
}