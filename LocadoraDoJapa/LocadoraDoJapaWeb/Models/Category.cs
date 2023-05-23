using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LocadoraDoJapaWeb.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display order")]
        public int DisplayOrder { get; set; }
    }
}
