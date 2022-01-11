using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class BancoDados : DbContext
    {
        public BancoDados(DbContextOptions<BancoDados> options) : base(options) { }
        public DbSet<Formulario> Formularios { get; set; }
        public DbSet<Curriculo> Curriculos { get; set; }
        
    }
}
