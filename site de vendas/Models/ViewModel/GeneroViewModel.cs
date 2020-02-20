using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http;

namespace site_de_vendas.Models.ViewModel {
    public class GeneroViewModel {
        public Genero GeneroMusical { get; set; }
        public List<Genero> ListaGeneros { get; set; }
        [Required(ErrorMessage = "Imagem requerida")]
        public IFormFile FileImage { get; set; }
    }
}