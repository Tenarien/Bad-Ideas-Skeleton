using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        public List<clsStock> StockList { get; set; }
        public int Count { get; set; }
        public clsStock ThisBook { get; set; }
    }
}