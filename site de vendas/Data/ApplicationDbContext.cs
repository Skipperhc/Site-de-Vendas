using Microsoft.EntityFrameworkCore;
using site_de_vendas.Models;

namespace site_de_vendas.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }
        
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<CasaShow> CasaShows { get; set; }
        public DbSet<Genero> Generos { get; set; }
    }
}