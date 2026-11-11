using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class OrderService
    {
        private IOrderStore store = new OrderStore();
        private SchedulingService scheduling = new SchedulingService();
        private List<Order> orders;

        public OrderService()
        {
            orders = store.LoadOrders();
        }

        // checks the order, gives it a number and saves it
        public Order PlaceOrder(Order order)
        {
            if (order.Items.Count == 0)
            {
                throw new InvalidOperationException("Please add at least one item to the order.");
            }
            if (!scheduling.CanAcceptOrder(order.PickupDate, orders))
            {
                throw new InvalidOperationException("Olivia cannot take more than " +
                    DailyCapacityRule.MaxOrdersPerDay + " orders for the same pickup day. Please choose another day.");
            }

            order.OrderId = GetNextId();
            order.OrderDate = DateTime.Now;
            order.Status = OrderStatus.Received;
            orders.Add(order);
            store.SaveOrders(orders);
            return order;
        }

        public List<Order> GetAllOrders()
        {
            return new List<Order>(orders);
        }

        private int GetNextId()
        {
            int highest = 0;
            foreach (Order order in orders)
            {
                if (order.OrderId > highest)
                {
                    highest = order.OrderId;
                }
            }
            return highest + 1;
        }

        // TODO (later phase)
        public void UpdateStatus(Order order, OrderStatus newStatus)
        {
            throw new NotImplementedException();
        }

        public void CancelOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void MarkAllergyReviewed(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
