using System.Security.Claims;
using System.Security.Policy;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using site_de_vendas.Models;
using site_de_vendas.Models.ViewModel;
using site_de_vendas.Repositories.Interface;

namespace site_de_vendas.Controllers {
    public class CasaShowController : Controller {

        private readonly ICasaShowRepository _casaShowRepository;

        public CasaShowController(ICasaShowRepository casaShowRepository) {
            _casaShowRepository = casaShowRepository;
        }

        // GET
        public IActionResult Index() {
            var listaCasas = _casaShowRepository.Listar();
            var viewModel = new CasaShowViewModel(){ListaCasaShows = listaCasas};
            return View(viewModel);
        }

        [HttpGet] public IActionResult Criar() {
            return View();
        }

        [HttpPost] public IActionResult Criar([FromForm] CasaShow casaShow) {
            _casaShowRepository.Adicionar(casaShow);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet] public IActionResult Editar(int id) {
            var casa = _casaShowRepository.Buscar(id);
            return View(casa);
        }

        [HttpPost] public IActionResult Editar([FromForm] CasaShow casaShow) {
            _casaShowRepository.Editar(casaShow);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet] public IActionResult Detalhar(int id) {
            var casa = _casaShowRepository.Buscar(id);
            return View(casa);
        }

        [HttpPost] public IActionResult Deletar(int id) {
            var casa = _casaShowRepository.Buscar(id);
            _casaShowRepository.Remover(casa);
            return RedirectToAction(nameof(Index));
        }
    }
}