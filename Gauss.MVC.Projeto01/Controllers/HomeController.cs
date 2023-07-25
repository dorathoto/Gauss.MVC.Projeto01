using Gauss.MVC.Projeto01.Data;
using Gauss.MVC.Projeto01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Gauss.MVC.Projeto01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //criando Classe autor
            var autor = new Autor
            {
                //  AutorId = 1, //desabilitado para o migration
                Name = "Leonardo Doratiotto"
            };
            _context.Autores.Add(autor);

            var livros = new List<Livro>();

            for (int i = 0; i < 10; i++)
            {
                livros.Add(new Livro
                {
                    Titulo = $"Livro {i}",
                    ISBN13 = $"ISBN13 {i}",
                    DataCadastro = DateTime.Now.AddDays(i),
                    AutorId = autor.AutorId, //relação do id
                    Autor = autor, //relação com o objeto autor
                    LivroId = Guid.NewGuid()
                });
            }


            _context.Livros.AddRange(livros);
          //  await _context.SaveChangesAsync(); //Assincrono - explicar (modificar no começo da action)
            //_context.SaveChanges();

            return View(livros);
        }

        public IActionResult Listagem()
        {
            var teste1 = _context.Livros.FirstOrDefault();
            var listaLivros = _context.Livros.ToList();
            //var listaLivros = _context.Livros.Include(x => x.Autor).ToList();
            return View(listaLivros);
        }


    }
}