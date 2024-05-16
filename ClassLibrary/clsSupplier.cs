using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public clsSupplier() { }
        public Int32 SupplierId { get; set; }
        public string SupplierName { get; set; }
        public DateTime ContractDate { get; set; }
        public bool AvailableSupplier { get; set; }
        public string SupplierAddress { get; set; }
    }

}