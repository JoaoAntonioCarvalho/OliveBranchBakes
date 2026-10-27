namespace OliveBranchBakes.Models
{
    // customer without an account, nothing is saved for next time
    public class GuestCustomer : Customer
    {
        public string? Email { get; set; }  // optional for guests
    }
}
