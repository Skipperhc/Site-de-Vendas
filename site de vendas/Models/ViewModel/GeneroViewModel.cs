﻿using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http;

namespace site_de_vendas.Models.ViewModel {
    public class GeneroViewModel {
        public Genero GeneroMusical { get; set; }
        public List<Genero> ListaGeneros { get; set; }
        public IFormFile FileImage { get; set; }
    }
}