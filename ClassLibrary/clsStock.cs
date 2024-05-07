using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public int BookId { get; set; }
        public DateTime DateAdded { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public bool Available { get; set; }
        public int Quantity { get; set; }
        public int SupplierId { get; set; }
    }
}