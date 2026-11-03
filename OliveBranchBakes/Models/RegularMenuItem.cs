using System.Text.Json.Serialization;

namespace OliveBranchBakes.Models
{
    // sold all year
    public class RegularMenuItem : MenuItem
    {
        [JsonIgnore]
        public override bool IsSeasonal
        {
            get { return false; }
        }

        public override bool IsInSeason(DateTime date)
        {
            return true;
        }
    }
}
