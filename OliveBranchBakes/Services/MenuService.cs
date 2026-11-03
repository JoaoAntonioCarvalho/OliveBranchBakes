using OliveBranchBakes.Models;
using MenuItem = OliveBranchBakes.Models.MenuItem;

namespace OliveBranchBakes.Services
{
    public class MenuService
    {
        private DataStore store = new DataStore();
        private List<MenuItem> items;

        public MenuService()
        {
            items = store.LoadMenu();
        }

        // items the customer can order for this pickup date, category null means all categories
        public List<MenuItem> GetVisibleItems(DateTime pickupDate, MenuCategory? category)
        {
            List<MenuItem> visible = new List<MenuItem>();
            foreach (MenuItem item in items)
            {
                if (!item.IsVisibleOn(pickupDate))
                {
                    continue;
                }
                if (category != null && item.Category != category)
                {
                    continue;
                }
                visible.Add(item);
            }
            return visible;
        }

        public void SetAvailability(int menuItemId, bool isAvailable)
        {
            foreach (MenuItem item in items)
            {
                if (item.MenuItemId == menuItemId)
                {
                    item.IsAvailable = isAvailable;
                    store.SaveMenu(items);
                    return;
                }
            }
        }
    }
}
