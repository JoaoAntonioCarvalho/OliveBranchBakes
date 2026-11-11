using System.Text.Json.Serialization;

namespace OliveBranchBakes.Models
{
    // base class with the data guest and account customers share. The json file needs to know which child class to load.
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
    [JsonDerivedType(typeof(AccountCustomer), "account")]
    [JsonDerivedType(typeof(GuestCustomer), "guest")]
    public abstract class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; } = "";
        public string Phone { get; set; } = "";
    }
}
