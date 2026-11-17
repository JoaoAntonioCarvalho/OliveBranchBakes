using System.Text.Json.Serialization;
using OliveBranchBakes.Services;
using MenuItem = OliveBranchBakes.Models.MenuItem;

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
            // copy only the items that are still on the menu for today
            MenuService menuService = new MenuService();
            List<MenuItem> available = menuService.GetVisibleItems(DateTime.Today, null);

            Order newOrder = new Order();
            newOrder.Customer = this;
            foreach (OrderItem line in pastOrder.Items)
            {
                foreach (MenuItem item in available)
                {
                    if (line.Item != null && item.MenuItemId == line.Item.MenuItemId)
                    {
                        newOrder.AddItem(item, line.Quantity);
                    }
                }
            }
            return newOrder;
        }
    }
}
