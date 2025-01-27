namespace Backend.Models.DTO
{
    public class RatingListEntry
    {
        public int RatingId { get; set; }

        public string ProductName { get; set; }

        public string ProviderName { get; set; }

        public float Value { get; set; }
    }
}
