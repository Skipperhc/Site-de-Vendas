using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using site_de_vendas.Models;
using site_de_vendas.Models.ViewModel;
using site_de_vendas.Repositories;
using site_de_vendas.Repositories.Interface;

namespace site_de_vendas.Controllers {
    public class HomeController : Controller {

        private readonly IEventoRepository _eventoRepository;
        private readonly ICasaShowRepository _casaShowRepository;
        private readonly IGeneroRepository _generoRepository;

        public HomeController(IEventoRepository eventoRepository, ICasaShowRepository casaShowRepository, IGeneroRepository generoRepository) {
            _eventoRepository = eventoRepository;
            _casaShowRepository = casaShowRepository;
            _generoRepository = generoRepository;
        }

        public IActionResult Index() {
            var list = _eventoRepository.Listar();
            return View(list);
        }

        [HttpGet] public IActionResult Criar() {
            var generos = _generoRepository.Listar();
            var casaShows = _casaShowRepository.Listar();
            var viewModel = new  EventoViewModel() {CasaShows = casaShows, Generos = generos};
            return View(viewModel);
        }

        [HttpPost] public IActionResult Criar([FromForm]Evento evento) {
            evento.Id = 0;
            _eventoRepository.Adicionar(evento);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet] public IActionResult Editar(int id) {
            var evento = _eventoRepository.Buscar(id);
            var generos = _generoRepository.Listar();
            var casaShows = _casaShowRepository.Listar();
            var viewModel = new  EventoViewModel() {CasaShows = casaShows, Evento = evento, Generos = generos};
            return View(viewModel);
        }
        
        [HttpPost] public IActionResult Editar([FromForm] Evento evento) {
            _eventoRepository.Editar(evento);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet] public IActionResult Detalhar(int id) {
            var evento = _eventoRepository.Buscar(id);
            var generos = _generoRepository.Listar();
            var casaShows = _casaShowRepository.Listar();
            var viewModel = new  EventoViewModel() {CasaShows = casaShows, Evento = evento, Generos = generos};
            return View(viewModel);
        }

        [HttpPost] public IActionResult Deletar(int id) {
            var evento = _eventoRepository.Buscar(id);
            _eventoRepository.Remover(evento);
            return RedirectToAction(nameof(Index));
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View
            (new ErrorViewModel {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}