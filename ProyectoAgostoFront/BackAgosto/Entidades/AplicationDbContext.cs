using Microsoft.EntityFrameworkCore;

namespace BackAgosto.Entidades
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Inventario> Inventarios {get; set; }
        public DbSet<DetalleInventario> DetalleInventario { get; set; }


    }
}
