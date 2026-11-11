using OliveBranchBakes.Services;

namespace OliveBranchBakes.Models
{
    // one order can have many items
    public class Order
    {
        public const int MinQuantity = 1;
        public const int MaxQuantity = 50;   // same limit as VR-4

        public int OrderId { get; set; }
        public Customer? Customer { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public DateTime OrderDate { get; set; }
        public DateTime PickupDate { get; set; }   // pickup only, no delivery
        public OrderStatus Status { get; set; } = OrderStatus.Received;
        public AllergyInfo? Allergy { get; set; }

        public void AddItem(MenuItem item, int quantity)
        {
            // if the item is already in the order, add to that line
            OrderItem? line = FindLine(item);
            int newQuantity = quantity;
            if (line != null)
            {
                newQuantity = line.Quantity + quantity;
            }
            CheckQuantity(newQuantity);

            if (line == null)
            {
                line = new OrderItem();
                line.Item = item;
                line.UnitPrice = item.Price;
                Items.Add(line);
            }
            line.Quantity = newQuantity;
        }

        public void ChangeQuantity(OrderItem orderItem, int quantity)
        {
            CheckQuantity(quantity);
            orderItem.Quantity = quantity;
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public decimal GetSubtotal()
        {
            decimal subtotal = 0;
            foreach (OrderItem line in Items)
            {
                subtotal += line.GetLineTotal();
            }
            return subtotal;
        }

        // subtotal minus the discount from the variant card
        public decimal GetTotal()
        {
            PricingService pricing = new PricingService();
            return pricing.GetTotal(this);
        }

        private OrderItem? FindLine(MenuItem item)
        {
            foreach (OrderItem line in Items)
            {
                if (line.Item != null && line.Item.MenuItemId == item.MenuItemId)
                {
                    return line;
                }
            }
            return null;
        }

        private void CheckQuantity(int quantity)
        {
            if (quantity < MinQuantity || quantity > MaxQuantity)
            {
                throw new ArgumentException("The quantity of one item must be between " +
                    MinQuantity + " and " + MaxQuantity + ".");
            }
        }
    }
}
