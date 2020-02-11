using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using site_de_vendas.Models;
using site_de_vendas.Models.ViewModel;
using site_de_vendas.Repositories.Interface;

namespace site_de_vendas.Controllers {
    public class GeneroController : Controller {
        private readonly IGeneroRepository _generoRepository;

        public GeneroController(IGeneroRepository generoRepository) {
            _generoRepository = generoRepository;
        }

        // GET
        public IActionResult Index() {
            var listaGeneros = _generoRepository.Listar();
            var viewModel = new GeneroViewModel(){ListaGeneros = listaGeneros};
            return View(viewModel);
        }

        [HttpPost] public IActionResult Criar([FromForm] Genero genero) {
            _generoRepository.Adicionar(genero);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet] public IActionResult Editar(int id) {
            var genero = _generoRepository.Buscar(id);
            return View(genero);
        }

        [HttpPost] public IActionResult Editar([FromForm] Genero genero) {
            _generoRepository.Editar(genero);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet] public IActionResult Detalhar(int id) {
            var genero = _generoRepository.Buscar(id);
            return View(genero);
        }

        [HttpPost] public IActionResult Deletar(int id) {
            var casa = _generoRepository.Buscar(id);
            _generoRepository.Remover(casa);
            return RedirectToAction(nameof(Index));
        }
    }
}