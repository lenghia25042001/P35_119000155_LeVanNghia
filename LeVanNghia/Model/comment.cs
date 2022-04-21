using System.ComponentModel.DataAnnotations;

namespace LeVanNghia.Model
{
    public class News
    {
        [Key]
        public int ID { get; set; }
        [Required]
        
        public string Content { get; set; }
            
        [Required]
        public string Author { get; set; }
        
        public DataTime CreatedAt { get; set; }
    }
}