using ManagEvent.Domain;
using Microsoft.EntityFrameworkCore;

namespace ManagEvent.Repository
{
    public class ManagEventContext : DbContext
    {
        public ManagEventContext(DbContextOptions<ManagEventContext> options) : base (options) {}
        public DbSet<Evento> Eventos { get ; set; }
        public DbSet<Palestrante> Palestrantes { get ; set; }
        public DbSet<PalestranteEvento> PalestranteEventos { get ; set; }
        public DbSet<Lote> Lotes { get ; set; }
        public DbSet<RedeSocial> RedesSociais { get ; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<PalestranteEvento>()
                .HasKey(PE => new { PE.EventoId, PE.PalestranteId});
        }
    }
}