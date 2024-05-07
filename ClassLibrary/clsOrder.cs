using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public clsOrder() { }

        public bool ShippingStatus { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
    }
}