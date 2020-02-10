namespace site_de_vendas.Models {
    public class Evento {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double preco { get; set; }
        public CasaShow CasaShow { get; set; }
        public int CasaShowId { get; set; }
    }
}