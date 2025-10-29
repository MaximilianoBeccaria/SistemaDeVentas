using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaDeVentas.Models;



namespace SistemaDeVentas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<DetalleOrden> DetalleOrden { get; set; }
        public DbSet<Orden> Orden { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=LAPTOP-J7C6C098\\SQLEXPRESS;Database=Grupo10;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
       


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalleOrden>()
                .HasKey(d => new { d.OrdenId, d.ProductoId });

            modelBuilder.Entity<Orden>()
                .HasMany(o => o.Detalles)
                .WithOne()
                .HasForeignKey(d => d.OrdenId);

            modelBuilder.Entity<Producto>()
                .HasMany(p => p.DetallesOrden)
                .WithOne()
                .HasForeignKey(d => d.ProductoId);
        }





    }
}

