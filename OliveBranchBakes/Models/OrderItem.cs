namespace OliveBranchBakes.Models
{
    // one line of an order (item + quantity)
    public class OrderItem
    {
        public MenuItem? Item { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }   // price saved when the order is made

        public decimal GetLineTotal()
        {
            // TODO (later phase)
            throw new NotImplementedException();
        }
    }
}
