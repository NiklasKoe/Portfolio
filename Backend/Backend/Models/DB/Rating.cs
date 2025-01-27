using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DB
{


    public class Rating
    {
        [Key]
        public int Id { get; set; }

        public float Value { get; set; }

        public int ProductId { get; set; }

        public int ProviderId { get; set; }
    }
}
