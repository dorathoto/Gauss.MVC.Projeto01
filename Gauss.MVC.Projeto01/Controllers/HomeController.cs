using Gauss.MVC.Projeto01.Data;
using Gauss.MVC.Projeto01.Models;
using Microsoft.AspNetCore.Mvc;
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
            //segundo momento
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
                    AutorId = autor.AutorId, //segundo momento
                    Autor = autor, //segundo momento
                    LivroId = Guid.NewGuid()
                });
            }

            _context.Livros.AddRange(livros);
            await _context.SaveChangesAsync();


            return View(livros);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}