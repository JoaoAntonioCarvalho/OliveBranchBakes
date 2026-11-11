using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    // anything that can save and load the orders
    public interface IOrderStore
    {
        void SaveOrders(List<Order> orders);
        List<Order> LoadOrders();
    }
}
