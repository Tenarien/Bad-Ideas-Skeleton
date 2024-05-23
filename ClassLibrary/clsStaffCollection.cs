using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();

        clsStaff mThisStaff = new clsStaff();
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            { 
                return mStaffList.Count;
            }
            set
            {

            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStaff_SelectAll");

            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffDateAdded", mThisStaff.StaffDate);
            DB.AddParameter("@StaffPrivilage", mThisStaff.StaffPrivilage);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffDateAdded", mThisStaff.StaffDate);
            DB.AddParameter("@StaffPrivilage", mThisStaff.StaffPrivilage);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);

            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByName(string StaffName)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffName", StaffName);
            DB.Execute("sproc_tblStaff_FilterByName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;

            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();

            while (Index < RecordCount)
            {
                clsStaff aStaff = new clsStaff();

                aStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                aStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                aStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                aStaff.StaffDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDateAdded"]);
                aStaff.StaffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]); ;
                aStaff.StaffPrivilage = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffPrivilage"]);

                mStaffList.Add(aStaff);
                Index++;
            }
        }
    }
    
}