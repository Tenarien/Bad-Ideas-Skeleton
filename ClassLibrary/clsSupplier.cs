using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private Int32 mSupplierId;
        private String mSupplierName;
        private DateTime mContractDate;
        private Boolean mAvailableSupplier;
        private string mSupplierAddress;


        public Int32 SupplierId
        {
            get
            {
                return mSupplierId;
            }
            set
            {
                mSupplierId = value;
            }
        }

        public string SupplierName
        {
            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }
        }
        public DateTime ContractDate
        {
            get
            {
                return mContractDate;
            }
            set
            {
                mContractDate = value;
            }
        }

        public bool AvailableSupplier
        {
            get
            {
                return mAvailableSupplier;
            }
            set
            {
                mAvailableSupplier = value;
            }
        }

        public string SupplierAddress
        {
            get
            {
                return mSupplierAddress;
            }
            set
            {
                mSupplierAddress = value;
            }
        }


        public bool Find(int supplierId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", supplierId);
            DB.Execute("sproc_tblSupplier_FilterbySupplierId");

            if (DB.Count == 1)
            {
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                mAvailableSupplier = Convert.ToBoolean(DB.DataTable.Rows[0]["AvailableSupplier"]);
                mContractDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ContractDate"]);
                return true;

            }

            else
            {
                return false;
            }
        }

        public string Valid(string supplierName, string supplierAddress, string contractDate, string availableSupplier)
        {
            String Error = "";
            DateTime TestDate;

            if(supplierName.Length == 0)
            {
                Error += "SupplierName Cant be Empty.";
            }
            if (supplierName.Length >= 21)
            {
                Error += "SupplierName is OverLimit. Limit is 20 Characters.";
            }

            if (supplierAddress.Length == 0)
            {
                Error += "Supplier Address Cant be Empty.";
            }
            if (supplierAddress.Length >= 51)
            {
                Error += "SupplierAddress is OverLimit. Limit is 50 Characters.";
            }

            try
            {
                TestDate = Convert.ToDateTime(contractDate);
                if(TestDate < DateTime.Now.Date)
                {
                    Error += "DAte Can't be in the Past.";
                }
                if (TestDate > DateTime.Now.Date)
                {
                    Error += "DAte Can't be in the Future.";
                }
            }
            catch
            {
                Error += "Date is in Invalid formaat.";
            }
            return Error;
        }
    }

}