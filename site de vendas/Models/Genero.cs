using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace site_de_vendas.Models {
    public class Genero {
        public int Id { get; set; }
        
        
        [Required(ErrorMessage = "{0} Requerido")]
        public string Nome { get; set; }
    }
}