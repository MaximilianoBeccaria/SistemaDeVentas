using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Models
{
    public class Proveedor
    {
        [Key]
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }

        public List<Producto> Productos { get; set; }
    }
}