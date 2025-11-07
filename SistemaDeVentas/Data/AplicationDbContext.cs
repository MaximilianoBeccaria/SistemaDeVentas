using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeVentas.Data; 
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
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=SistedeVenta;TrustServerCertificate=True;"
            );
        }
       


        
        



    }



}




    






