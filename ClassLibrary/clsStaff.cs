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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the addres if
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the databse into the private data properties
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mStaffDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDateAdded"]);
                mStaffRole = Convert.ToString(DB.DataTable.Rows[0]["StaffRole"]); ;
                mStaffPrivilage = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffPrivilage"]);
                //return true if all is okay
                return true;
            }
            else
            { 
                return false;
            }
        }
    }
}