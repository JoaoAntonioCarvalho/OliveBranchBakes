namespace OliveBranchBakes.Models
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = true;   // Olivia turns items on and off
        public bool IsSeasonal { get; set; }
    }
}
