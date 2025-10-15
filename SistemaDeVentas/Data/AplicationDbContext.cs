using Microsoft.EntityFrameworkCore;
using SistemaVentasDatos.Modelos;

namespace SistemaVentasDatos.Datos
{
    public class VentasContext : DbContext
    {

        public VentasContext(DbContextOptions<VentasContext> options) : base(options) { }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<DetalleOrden> DetallesOrden { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=VentasDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }

    }
}
