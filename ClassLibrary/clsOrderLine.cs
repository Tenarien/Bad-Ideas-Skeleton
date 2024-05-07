namespace ClassLibrary
{
    public class clsOrderLine
    {
        public int OrderLineId { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public bool OrderLineStatus { get; set; }
    }
}