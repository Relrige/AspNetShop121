using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required, MinLength(3, ErrorMessage = "Name must has at least 3 characters.")]
        public string? Title { get; set; }

        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        [StringLength(1000, MinimumLength = 2)]
        public string? City { get; set; }

        public string? ImageUrl { get; set; }

        public string? Condition { get; set; }



        [StringLength(1000, MinimumLength = 10)]
        public string? Description { get; set; }

        [StringLength(1000, MinimumLength = 2 )]
        public string? Contact { get; set; }

        public Category? Category { get; set; }
    }
}