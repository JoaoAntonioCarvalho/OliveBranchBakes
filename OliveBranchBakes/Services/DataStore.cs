using System.Text.Json;
using OliveBranchBakes.Models;
using MenuItem = OliveBranchBakes.Models.MenuItem;

namespace OliveBranchBakes.Services
{
    // saves and loads the menu in a json file
    public class DataStore
    {
        private string folderPath;
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
        }

        public DataStore()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            folderPath = Path.Combine(appData, "OliveBranchBakes");
            filePath = Path.Combine(folderPath, "menu.json");
        }

        public List<MenuItem> GetSeedMenu()
        {
            List<MenuItem> items = new List<MenuItem>();
            items.Add(CreateItem(1, "Chocolate Chip Cookies", "dozen", 12.00m, MenuCategory.Cookies));
            items.Add(CreateItem(2, "Cinnamon Rolls", "6 pack", 15.00m, MenuCategory.Pastries));
            items.Add(CreateItem(3, "Sourdough Bread", "loaf", 8.00m, MenuCategory.Breads));
            items.Add(CreateItem(4, "Blueberry Muffins", "dozen", 14.00m, MenuCategory.Pastries));
            items.Add(CreateItem(5, "Birthday Cake (8 in)", "each", 35.00m, MenuCategory.Cakes));

            // Pumpkin Bread is only sold in the fall, September 1 to November 30
            items.Add(CreateSeasonalItem(6, "Pumpkin Bread", "loaf", 9.00m, MenuCategory.Breads,
                new DateTime(2000, 9, 1), new DateTime(2000, 11, 30)));
            return items;
        }

        private MenuItem CreateItem(int id, string name, string description, decimal price, MenuCategory category)
        {
            RegularMenuItem item = new RegularMenuItem();
            item.MenuItemId = id;
            item.Name = name;
            item.Description = description;
            item.Price = price;
            item.IsAvailable = true;
            item.Category = category;
            return item;
        }

        private MenuItem CreateSeasonalItem(int id, string name, string description, decimal price,
            MenuCategory category, DateTime seasonStart, DateTime seasonEnd)
        {
            SeasonalMenuItem item = new SeasonalMenuItem();
            item.MenuItemId = id;
            item.Name = name;
            item.Description = description;
            item.Price = price;
            item.IsAvailable = true;
            item.Category = category;
            item.SeasonStart = seasonStart;
            item.SeasonEnd = seasonEnd;
            return item;
        }

        public void SaveMenu(List<MenuItem> items)
        {
            try
            {
                Directory.CreateDirectory(folderPath);
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string json = JsonSerializer.Serialize(items, options);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the menu: " + ex.Message);
            }
        }

        public List<MenuItem> LoadMenu()
        {
            // first run: no file yet, so save the seed data
            if (!File.Exists(filePath))
            {
                List<MenuItem> seed = GetSeedMenu();
                SaveMenu(seed);
                return seed;
            }

            try
            {
                string json = File.ReadAllText(filePath);
                List<MenuItem>? items = JsonSerializer.Deserialize<List<MenuItem>>(json);
                if (items == null || items.Count == 0)
                {
                    throw new Exception("The menu file is empty.");
                }
                return items;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not read the menu file, using the seed menu instead. " + ex.Message);
                return GetSeedMenu();
            }
        }
    }
}
