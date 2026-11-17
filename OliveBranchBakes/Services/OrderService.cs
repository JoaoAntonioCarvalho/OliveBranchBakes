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

        // Olivia moves the order to the next step (or any step she needs)
        public void UpdateStatus(Order order, OrderStatus newStatus)
        {
            if (order.Status == OrderStatus.Cancelled || order.Status == OrderStatus.PickedUp)
            {
                throw new InvalidOperationException("This order is already finished and cannot change.");
            }
            order.Status = newStatus;
            store.SaveOrders(orders);
        }

        // a cancelled order does not use up the baking capacity of its pickup day
        public void CancelOrder(Order order)
        {
            UpdateStatus(order, OrderStatus.Cancelled);
        }

        // Olivia checks the allergy information before she bakes
        public void MarkAllergyReviewed(Order order)
        {
            if (order.Allergy == null)
            {
                throw new InvalidOperationException("This order has no allergy information.");
            }
            order.Allergy.IsReviewedByAdmin = true;
            store.SaveOrders(orders);
        }
    }
}
