using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
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
        public clsStaff ThisStaff { get; set; }
        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStaff_SelectAll");

            RecordCount = DB.Count;
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