using System.ComponentModel.DataAnnotations;

namespace VeraoSorvete.Models
{
    public class Sorvete
    {
        [Key]
        public int SorveteId { get; set; }

        [Required]
        
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int Preco { get; set; }

        public string ImagemURL { get; set; }

        public string ImagemThumbnailUrl { get; set; }

        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria{ get; set; }
    }
}
