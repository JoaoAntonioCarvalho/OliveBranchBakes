using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class SchedulingService
    {
        private OperationsRule rule = new DailyCapacityRule();

        // cancelled orders do not use up the baking capacity
        public int CountOrdersOn(DateTime pickupDate, List<Order> orders)
        {
            int count = 0;
            foreach (Order order in orders)
            {
                if (order.PickupDate.Date == pickupDate.Date && order.Status != OrderStatus.Cancelled)
                {
                    count++;
                }
            }
            return count;
        }

        public bool CanAcceptOrder(DateTime pickupDate, List<Order> orders)
        {
            return rule.CanAccept(CountOrdersOn(pickupDate, orders));
        }
    }
}
