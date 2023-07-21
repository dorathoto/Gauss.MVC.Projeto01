namespace Gauss.MVC.Projeto01.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
