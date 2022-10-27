using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_Repositorio_Mvc.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Titulo { get; set; }
        public string Autor { get; set; }

        [Column("Ano")]
        [Display(Name = "Ano Publicacao")]
        public string AnoPublicacao { get; set; }

        [Column("Preco")]
        [Display(Name = "Preco")]
        public decimal Preco { get; set; }
    }
}