namespace Backend.Models.DTO
{
    public class CreateOrUpdateRating
    {
        public int Value { get; set; }

        public int ProviderId { get; set; }

        public int ProductId { get; set; }
    }
}