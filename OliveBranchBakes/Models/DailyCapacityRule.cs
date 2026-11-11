namespace OliveBranchBakes.Models
{
    // variant card rule: at most 10 orders for the same pickup day
    public class DailyCapacityRule : OperationsRule
    {
        public const int MaxOrdersPerDay = 10;

        public override bool CanAccept(int ordersOnDay)
        {
            return ordersOnDay + 1 <= MaxOrdersPerDay;
        }
    }
}
