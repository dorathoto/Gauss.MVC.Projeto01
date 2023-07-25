using System.ComponentModel.DataAnnotations;

namespace Gauss.MVC.Projeto01.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        [MaxLength(110, ErrorMessage = "O Máximo de caracteres é {0}")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
