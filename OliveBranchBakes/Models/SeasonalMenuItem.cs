using System.Text.Json.Serialization;

namespace OliveBranchBakes.Models
{
    // only sold between two dates every year
    public class SeasonalMenuItem : MenuItem
    {
        // only the month and the day are used, the year does not matter
        public DateTime SeasonStart { get; set; }
        public DateTime SeasonEnd { get; set; }

        [JsonIgnore]
        public override bool IsSeasonal
        {
            get { return true; }
        }

        public override bool IsInSeason(DateTime date)
        {
            // turn each date into a number like 1130 for November 30, so they are easy to compare
            int day = date.Month * 100 + date.Day;
            int start = SeasonStart.Month * 100 + SeasonStart.Day;
            int end = SeasonEnd.Month * 100 + SeasonEnd.Day;

            if (start <= end)
            {
                return day >= start && day <= end;
            }

            // the season goes over New Year, like December 1 to February 28
            return day >= start || day <= end;
        }
    }
}
