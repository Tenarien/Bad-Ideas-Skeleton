using System;

namespace ClassLibrary
{
    public class clsSupplierUser
    {
        private int mUserId;
        private String mUserName;
        private String mPassword;
        private String mDepartment;


        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }

        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }

        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }

        public int UserId
        {
            get
            {
                return mUserId;
            }
            set
            {
                mUserId = value;
            }
        }

        public bool FindUser(string userName, string password)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);

            DB.Execute("sproc_tblUsers_FindUserNamePWSuppliers");

            if (DB.Count == 1)
            {
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}