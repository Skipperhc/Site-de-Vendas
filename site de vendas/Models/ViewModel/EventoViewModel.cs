using System.Collections.Generic;

namespace site_de_vendas.Models.ViewModel {
    public class EventoViewModel {
        public Evento Evento { get; set; }
        public List<CasaShow> CasaShows { get; set; }
    }
}