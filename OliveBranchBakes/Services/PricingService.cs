using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class PricingService
    {
        private PricingRule rule = new SubtotalDiscountRule();

        public decimal GetDiscount(Order order)
        {
            return rule.GetDiscount(order.GetSubtotal());
        }

        public decimal GetTotal(Order order)
        {
            decimal total = order.GetSubtotal() - GetDiscount(order);
            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }
    }
}
