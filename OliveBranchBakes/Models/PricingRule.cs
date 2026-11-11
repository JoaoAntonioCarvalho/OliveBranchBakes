namespace OliveBranchBakes.Models
{
    // base class for the pricing rules. Each rule decides its own discount.
    public abstract class PricingRule
    {
        // discount in dollars for this subtotal
        public abstract decimal GetDiscount(decimal subtotal);
    }
}
