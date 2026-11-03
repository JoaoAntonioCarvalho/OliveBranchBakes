using System.Text.Json.Serialization;

namespace OliveBranchBakes.Models
{
    // base class for everything on the menu. The json file needs to know which child class to load.
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
    [JsonDerivedType(typeof(RegularMenuItem), "regular")]
    [JsonDerivedType(typeof(SeasonalMenuItem), "seasonal")]
    public abstract class MenuItem
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = true;   // Olivia turns items on and off

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MenuCategory Category { get; set; }

        [JsonIgnore]
        public abstract bool IsSeasonal { get; }

        // each kind of item decides if it can be sold on this date
        public abstract bool IsInSeason(DateTime date);

        // the customer only sees items that are turned on and in season
        public bool IsVisibleOn(DateTime date)
        {
            return IsAvailable && IsInSeason(date);
        }
    }
}
