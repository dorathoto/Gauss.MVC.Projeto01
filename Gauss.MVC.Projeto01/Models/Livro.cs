using System.ComponentModel.DataAnnotations;

namespace Gauss.MVC.Projeto01.Models
{
    public class Livro
    {
        public Guid LivroId { get; set; }
        public int AutorId { get; set; } //segundo momento
        public string Titulo { get; set; }

        [MaxLength(13, ErrorMessage ="Oh mané só 13 caracteres")]
        public string ISBN13 { get; set; }

        public DateTime DataCadastro { get; set; }

        public virtual Autor Autor { get; set; }
    }
}
