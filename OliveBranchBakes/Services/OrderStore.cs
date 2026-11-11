using System.Text.Json;
using System.Text.Json.Serialization;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    // saves and loads the orders in a json file
    public class OrderStore : IOrderStore
    {
        private string folderPath;
        private string filePath;

        public OrderStore()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            folderPath = Path.Combine(appData, "OliveBranchBakes");
            filePath = Path.Combine(folderPath, "orders.json");
        }

        private JsonSerializerOptions GetOptions()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.Converters.Add(new JsonStringEnumConverter());
            return options;
        }

        public void SaveOrders(List<Order> orders)
        {
            try
            {
                Directory.CreateDirectory(folderPath);
                string json = JsonSerializer.Serialize(orders, GetOptions());
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the orders: " + ex.Message);
            }
        }

        public List<Order> LoadOrders()
        {
            if (!File.Exists(filePath))
            {
                return new List<Order>();
            }

            try
            {
                string json = File.ReadAllText(filePath);
                List<Order>? orders = JsonSerializer.Deserialize<List<Order>>(json, GetOptions());
                if (orders == null)
                {
                    return new List<Order>();
                }
                return orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not read the orders file. " + ex.Message);
                return new List<Order>();
            }
        }
    }
}
