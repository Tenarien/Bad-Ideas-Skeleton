﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        private List<clsSupplier> mSupplierlist = new List<clsSupplier>();
        private clsSupplier mThisSupplier = new clsSupplier();

        public clsSupplierCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            RecordCount = DB.Count;


            while (Index < RecordCount)
            {
                clsSupplier ASupplier = new clsSupplier();

                ASupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.SupplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["SupplierAddress"]);
                ASupplier.AvailableSupplier = Convert.ToBoolean(DB.DataTable.Rows[Index]["AvailableSupplier"]);
                ASupplier.ContractDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ContractDate"]);

                mSupplierlist.Add(ASupplier);
                Index++;
            }
        }

        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierlist;
            }
            set
            {
                mSupplierlist = value;
            }
        }

        public int Count
        {
            get
            {
                return mSupplierlist.Count;
            }
            set
            {

            }
        }
        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }
    }
}
