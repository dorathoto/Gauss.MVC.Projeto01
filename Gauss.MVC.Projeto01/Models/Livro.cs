using System.ComponentModel.DataAnnotations;

namespace Gauss.MVC.Projeto01.Models
{
    public class Livro
    {
        public Guid LivroId { get; set; }
        [Display(Name = "Autor ID")]
        public int AutorId { get; set; } //segundo momento

        [MaxLength(110, ErrorMessage = "O Máximo de caracteres é {0}")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [MaxLength(13, ErrorMessage ="Oh mané só 13 caracteres")]
        public string ISBN13 { get; set; }

        public DateTime DataCadastro { get; set; }

        [Display(Name = "Autor")]
        public virtual Autor Autor { get; set; }
    }
}
