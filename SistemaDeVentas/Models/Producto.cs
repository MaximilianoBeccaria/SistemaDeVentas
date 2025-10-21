using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaDeVentas.Models
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string SKU { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public int Stock { get; set; }
        public string Categoria { get; set; }

        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        public List<DetalleOrden> DetallesOrden { get; set; }
    }
}