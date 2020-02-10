using Microsoft.EntityFrameworkCore;

namespace site_de_vendas.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }
    }
}