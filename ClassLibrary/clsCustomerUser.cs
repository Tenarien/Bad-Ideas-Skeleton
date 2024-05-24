using System;

namespace ClassLibrary
{
    public class clsCustomerUser
    {
        //private data member for property user id
        private Int32 mUserID;
        //private data member for property username
        private String mUserName;
        //private data member for property password
        private String mPassword;
        //private data member for property department
        private String mDepartment;

        public int UserID 
        { 
            get
            {
                //return private data
                return mUserID;
            }
            set
            {
                //set private data
                mUserID = value;
            }
        }

        public string UserName 
        {
            get
            {
                //return private data
                return mUserName;
            }
            set
            {
                //set private data
                mUserName = value;
            }
        }

        public string Password 
        {
            get
            {
                //return private data
                return mPassword;
            }
            set
            {
                //set private data
                mPassword = value;
            }
        }

        public string Department 
        {
            get
            {
                //return private data
                return mDepartment; ;
            }
            set
            {
                //set private data
                mDepartment = value;
            }
        }




        public bool FindUser(string UserName, string Password)
        {
            //create instance of datat connection
            clsDataConnection DB = new clsDataConnection();
            //add paramaters for the user username and password search
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("Password", Password);
            //execute stored procedure
            DB.Execute("sproc_tblUsers_FindUserNameCM");
            //if one record is found (there should be one or none)
            if (DB.Count == 1 ) 
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything workd ok
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}