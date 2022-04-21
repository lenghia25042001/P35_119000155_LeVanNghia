using System.ComponentModel.DataAnnotations;

namespace LeVanNghia.Model
{
    public class Category
    {
        [Key]

        public int ID { get; set; }
        [Required]
        [MaxLegth(200)]
        public string Name { get; set; }
    }

}