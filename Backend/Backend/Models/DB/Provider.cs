using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DB
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
