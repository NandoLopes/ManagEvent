using ManagEvent.WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ManagEvent.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Evento> Eventos { get ; set; }
    }
}