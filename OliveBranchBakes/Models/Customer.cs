namespace OliveBranchBakes.Models
{
    // base class with the data guest and account customers share
    public abstract class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; } = "";
        public string Phone { get; set; } = "";
    }
}
