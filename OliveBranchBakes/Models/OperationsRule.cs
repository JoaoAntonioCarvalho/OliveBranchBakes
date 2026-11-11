namespace OliveBranchBakes.Models
{
    // base class for the rules about how much Olivia can bake
    public abstract class OperationsRule
    {
        // ordersOnDay is how many orders are already booked for the pickup day
        public abstract bool CanAccept(int ordersOnDay);
    }
}
