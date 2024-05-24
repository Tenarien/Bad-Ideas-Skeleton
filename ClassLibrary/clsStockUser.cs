﻿using System;

namespace ClassLibrary
{
    public class clsStockUser
    {
        private Int32 mUserID;
        private String mUserName;
        private String mPassword;
        private String mDepartment;

        public int UserID 
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }

        }
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

        public bool FindUser(string UserName, string Password)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            DB.Execute("sproc_tblUsers_FindUserNameSK");
            if (DB.Count == 1)
            {
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
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