namespace OliveBranchBakes.Models
{
    // one order can have many items
    public class Order
    {
        public int OrderId { get; set; }
        public Customer? Customer { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public DateTime OrderDate { get; set; }
        public DateTime PickupDate { get; set; }   // pickup only, no delivery
        public OrderStatus Status { get; set; } = OrderStatus.Received;
        public AllergyInfo? Allergy { get; set; }

        // TODO (later phase): add the logic for these methods
        public void AddItem(MenuItem item, int quantity)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotal()
        {
            throw new NotImplementedException();
        }
    }
}
