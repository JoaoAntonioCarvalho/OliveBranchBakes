namespace OliveBranchBakes.Models
{
    // every order needs this, for guests and account customers
    public class AllergyInfo
    {
        public bool HasAllergy { get; set; }
        public string Details { get; set; } = "";
        public bool IsReviewedByAdmin { get; set; }   // Olivia checks it before baking
    }
}
