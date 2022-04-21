using System.ComponentModel.DataAnnotations;

namespace LeVanNghia.Model
{
    public class News
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLegth(200)]
        [MinLegth(50)]
        public string Title { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        [MaxLegth(500)]
        [MinLegth(100)]
        public string Content { get; set; }
        [Required]
        public string Author { get; set; }

        public DataTime CreatedAt { get; set; }

        [ForeignKey("CategotyID")]

        public Category? Category{get; set; }

        public ICollection<Content>? comments{get; set; }
        
    }
}