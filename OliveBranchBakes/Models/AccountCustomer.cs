using System.Text.Json.Serialization;

namespace OliveBranchBakes.Models
{
    public class AccountCustomer : Customer
    {
        public string Email { get; set; } = "";
        public AllergyInfo? SavedAllergyInfo { get; set; }   // customer still confirms it on each order
        [JsonIgnore]   // orders are saved in their own file, this avoids a loop when saving
        public List<Order> OrderHistory { get; set; } = new List<Order>();

        public Order Reorder(Order pastOrder)
        {
            // TODO (later phase): copy the items that are still available
            throw new NotImplementedException();
        }
    }
}
