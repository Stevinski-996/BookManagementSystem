using System.ComponentModel.DataAnnotations;

namespace BookstoreManagement.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [Range(0.01, 1000.00)]
        public double Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Genre { get; set; }
    }
}
