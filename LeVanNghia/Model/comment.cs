using System.ComponentModel.DataAnnotations;

namespace LeVanNghia.Model
{
    public class comment
    {
        [Key]
        public int ID { get; set; }
        [Required]
        
        public string Content { get; set; }
            
        [Required]
        public string Author { get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}