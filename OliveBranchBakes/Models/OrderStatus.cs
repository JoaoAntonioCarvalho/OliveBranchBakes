namespace OliveBranchBakes.Models
{
    // enum so the status can only be one of these values
    public enum OrderStatus
    {
        Received,
        Confirmed,
        InProgress,
        Ready,
        PickedUp,
        Cancelled
    }
}
