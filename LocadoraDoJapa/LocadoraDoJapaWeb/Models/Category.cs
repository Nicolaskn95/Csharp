using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LocadoraDoJapaWeb.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display order")]
        [Range(1,100,ErrorMessage="Deve ter entre 1-100 digitos")]
        public int DisplayOrder { get; set; }
    }
}
