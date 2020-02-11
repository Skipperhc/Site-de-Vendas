using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using site_de_vendas.Data;
using site_de_vendas.Models;
using site_de_vendas.Repositories.Interface;

namespace site_de_vendas.Repositories {
    public class EventoRepository : IEventoRepository {
        private readonly ApplicationDbContext _dbContext;

        public EventoRepository(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public void Adicionar(Evento entidade) {
            _dbContext.Add(entidade);
            _dbContext.SaveChanges();
        }

        public Evento Buscar(int id) {
            return _dbContext.Eventos.FirstOrDefault(x => x.Id == id);
        }

        public List<Evento> Listar() {
            return _dbContext.Eventos.Include(x => x.CasaShow).Include(x=> x.Genero).ToList();
        }

        public void Editar(Evento entidade) {
            _dbContext.Entry(entidade).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Remover(Evento entidade) {
            _dbContext.Eventos.Remove(entidade);
            _dbContext.SaveChanges();
        }
    }
}