namespace OliveBranchBakes.Models
{
    // variant card rule: 10% off the whole order when the subtotal is 50.00 or more
    public class SubtotalDiscountRule : PricingRule
    {
        public const decimal MinSubtotal = 50.00m;
        public const decimal DiscountRate = 0.10m;

        public override decimal GetDiscount(decimal subtotal)
        {
            if (subtotal < MinSubtotal)
            {
                return 0;
            }
            return Math.Round(subtotal * DiscountRate, 2, MidpointRounding.AwayFromZero);
        }
    }
}
