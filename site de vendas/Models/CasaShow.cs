using System.ComponentModel.DataAnnotations;

namespace site_de_vendas.Models {
    public class CasaShow {
        public int Id { get; set; }
        
        
        [Required(ErrorMessage = "{0} Requerido")]
        public string Nome { get; set; }
        
        
        [Required(ErrorMessage = "{0} Requerido")]
        [Display(Name="Endereço")]
        public string Endereco { get; set; }
        
        
        [Required(ErrorMessage = "{0} Requerido")]
        [Range(100.0, 5000.0, ErrorMessage = "{0} must be from {1} To {2}")]
        [Display(Name="Capacidade Max")]
        public int Capacidade { get; set; }
    }
}